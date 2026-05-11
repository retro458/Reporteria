using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReportesAPI.Data;
using ReportesAPI.Services;
using ReportesAPI.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace ReportesAPI.Controllers;

/*
    @ Erick Baudriz: Este controlador se encarga de manejar las solicitudes relacionadas con el kardex y existencias.
        - Proporciona endpoints para obtener el kardex por producto, el kardex general, y las existencias.
        - También incluye endpoints para generar reportes en Excel y PDF tanto para el kardex como para las existencias.
        - Se utiliza autorización para proteger estos endpoints, asegurando que solo usuarios autenticados puedan acceder a esta información.

        @Author: Erick Baudriz
*/
[ApiController]
[Route("api/[controller]")]
[Authorize]
public class KardexController : ControllerBase
{
    private readonly IKardexService _kardex;
    private readonly IReportGeneratorService _reports;
    private readonly ControlDTEContext _db;

    public KardexController(
        IKardexService kardex,
        IReportGeneratorService reports,
        ControlDTEContext db)
    {
        _kardex = kardex;
        _reports = reports;
        _db = db;
    }


    // ----------- para la parte de buscar producto por categoria 
    [HttpGet("categorias")]
    public async Task<IActionResult> GetCategorias()
    {
        // Buscamos en la tabla de productos, filtramos vacíos y traemos los distintos
        var lista = await _db.Productos
            .Where(p => p.Categoria != null && p.Categoria != "")
            .Select(p => p.Categoria)
            .Distinct()
            .OrderBy(c => c)
            .ToListAsync();

        return Ok(lista);
    }

    // ── Búsqueda de productos para el autocomplete
    [HttpGet("productos")]
    public async Task<IActionResult> BuscarProductos([FromQuery] string q)
    {
        if (string.IsNullOrWhiteSpace(q) || q.Length < 1)
            return Ok(new List<object>());

        var productos = await _db.Productos
            .AsNoTracking()
            .Where(p => p.Eliminado == false &&
                        (p.Codigo!.Contains(q) || p.Descripcion!.Contains(q)))
            .OrderBy(p => p.Codigo)
            .Take(10)
            .Select(p => new { codigo = p.Codigo, nombre = p.Descripcion, existencia = p.Existencia })
            .ToListAsync();

        return Ok(productos);
    }

    // ── Kardex por producto
    [HttpGet]
    public async Task<IActionResult> GetKardex(
        [FromQuery] string codigo,
        [FromQuery] DateTime desde,
        [FromQuery] DateTime hasta)
    {
        var data = await _kardex.ObtenerKardex(codigo, desde, hasta);
        return Ok(data);
    }

    // ── Kardex general (todos los productos)
    [HttpGet("general")]
    public async Task<IActionResult> GetKardexGeneral(
        [FromQuery] DateTime desde,
        [FromQuery] DateTime hasta,
        [FromQuery] string? q = null)
    {
        if (desde > hasta)
            return BadRequest("La fecha 'desde' no puede ser mayor que la fecha 'hasta'.");
        var data = await _kardex.ObtenerKardexGeneral(desde, hasta, q);
        return Ok(data);
    }

    // ── Existencias
    [HttpGet("existencias")]
    public async Task<IActionResult> GetExistencias(
     [FromQuery] string? q = null,
     [FromQuery] string? categoria = null,
     [FromQuery] string? estado = null,
     [FromQuery] int pagina = 1,
     [FromQuery] int size = 50)
    {

        var (items, totales) = await _kardex.ObtenerExistencias(q, categoria, estado, pagina, size,descripcion: q);

        // Devolvemos el objeto que Vue espera recibir
        return Ok(new
        {
            items,
            totales
        });
    }

    // ── Excel kardex
    [HttpGet("excel")]
    public async Task<IActionResult> ExcelKardex(
        [FromQuery] string codigo,
        [FromQuery] DateTime desde,
        [FromQuery] DateTime hasta)
    {
        // 1. Obtener el objeto KardexResult (trae Movimientos y SaldoInicial)
        var result = await _kardex.ObtenerKardex(codigo, desde, hasta);

        var producto = await _db.Productos.AsNoTracking()
                                .FirstOrDefaultAsync(p => p.Codigo == codigo);

        // 2. Pasar result.Movimientos y result.SaldoInicial al generador
        var bytes = _reports.ExcelKardex(result.Movimientos, codigo, producto?.Descripcion ?? "", desde, hasta, result.SaldoInicial);

        return File(bytes,
            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
            $"Kardex_{codigo}_{desde:yyyyMMdd}_{hasta:yyyyMMdd}.xlsx");
    }

    // ── PDF kardex
    [HttpGet("pdf")]
    public async Task<IActionResult> PdfKardex(
        [FromQuery] string codigo,
        [FromQuery] DateTime desde,
        [FromQuery] DateTime hasta)
    {
        // 1. Obtener el objeto KardexResult
        var result = await _kardex.ObtenerKardex(codigo, desde, hasta);

        var producto = await _db.Productos.AsNoTracking()
                              .FirstOrDefaultAsync(p => p.Codigo == codigo);

        // 2. Pasar result.Movimientos y result.SaldoInicial al generador
        var bytes = _reports.PdfKardex(result.Movimientos, codigo, producto?.Descripcion ?? "", desde, hasta, result.SaldoInicial);

        return File(bytes, "application/pdf",
            $"Kardex_{codigo}_{desde:yyyyMMdd}_{hasta:yyyyMMdd}.pdf");
    }

    // ── Excel existencias
    [HttpGet("existencias/excel")]
    public async Task<IActionResult> ExcelExistencias([FromQuery] string? q = null)
    {
        var resultado = await _kardex.ObtenerExistencias(q, null, null, 1, 10000,null);

        // Pasamos solo la lista de items (.Items) al generador de reportes
        var bytes = _reports.ExcelExistencias(resultado.Items);

        return File(bytes,
            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
            $"Existencias_{DateTime.Now:yyyyMMdd}.xlsx");
    }

    // ── PDF existencias
    [HttpGet("existencias/pdf")]
    public async Task<IActionResult> PdfExistencias([FromQuery] string? q = null)
    {
        var resultado = await _kardex.ObtenerExistencias(q, null, null, 1, 10000,null);

        var bytes = _reports.PdfExistencias(resultado.Items);

        return File(bytes, "application/pdf", $"Existencias_{DateTime.Now:yyyyMMdd}.pdf");
    }

    // Excel kardex general
    [HttpGet("general/excel")]
    public async Task<IActionResult> ExcelKardexGeneral(
    [FromQuery] DateTime desde, [FromQuery] DateTime hasta, [FromQuery] string? q = null, [FromQuery] string? tipoDocumento = "TODOS",[FromQuery] string? sort = "fecha_desc")
    {
        var data = await _kardex.ObtenerKardexGeneral(desde, hasta, q, tipoDocumento, sort);
        var bytes = _reports.ExcelKardexGeneral(data, desde, hasta);
        return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
            $"KardexGeneral_{desde:yyyyMMdd}_{hasta:yyyyMMdd}.xlsx");
    }

    [HttpGet("general/pdf")]
    public async Task<IActionResult> PdfKardexGeneral(
        [FromQuery] DateTime desde, [FromQuery] DateTime hasta, [FromQuery] string? q = null, [FromQuery] string? tipoDocumento = "TODOS",[FromQuery] string? sort = "fecha_desc")
    {
        var data = await _kardex.ObtenerKardexGeneral(desde, hasta, q,tipoDocumento, sort);
        var bytes = _reports.PdfKardexGeneral(data, desde, hasta);
        return File(bytes, "application/pdf",
            $"KardexGeneral_{desde:yyyyMMdd}_{hasta:yyyyMMdd}.pdf");
    }

    [HttpGet("stock/excel")]
    public async Task<IActionResult> ExcelProductoStock(
    [FromQuery] string? q = null,
    [FromQuery] string? categoria = null,
    [FromQuery] string? estado = null,
    [FromQuery] string? sort = "codigo")
    {
        // 
        //  registrosPorPagina muy alto (ej. 5000) para que el Excel traiga TODO lo filtrado
        var (items, _) = await _kardex.ObtenerExistencias(q, categoria, estado, 1, 5000,null);
        var query = items.AsQueryable();

        //verificacion de filtro de solo stock
        if (!string.IsNullOrEmpty(estado) && estado.Equals("true", StringComparison.OrdinalIgnoreCase))
    {
        query = query.Where(x => x.Existencia > 0);
    }

        query = sort switch
        {
            "descripcion" => query.OrderBy(x => x.Descripcion),
            "existencia" => query.OrderBy(x => x.Existencia),
            "existencia_desc" => query.OrderByDescending(x => x.Existencia),
            _ => query.OrderBy(x => x.Codigo)
        };

        //Título dinámico para el Excel
        string filtroTexto = (string.IsNullOrEmpty(categoria) || categoria == "TODAS")
                    ? "TODAS LAS CATEGORÍAS"
                    : $"CATEGORÍA: {categoria.ToUpper()}";

        if (!string.IsNullOrEmpty(estado) && estado.Equals("true", StringComparison.OrdinalIgnoreCase))
        {
            filtroTexto += " | SOLO PRODUCTOS CON STOCK";
        }
        //Mapear al DTO  de reportes
        var dataDto = query.Select(x => new ProductoDTO
        {
            Codigo = x.Codigo,
            Descripcion = x.Descripcion,
            Categoria = x.Categoria,
            Existencia = (decimal)x.Existencia,
            PrecioVenta = (decimal)x.Precio,
            StockMinimo = (decimal)x.StockMinimo,
            UnidadMedida = x.Unidad
        })
        .ToList();

        // 3. Generar los bytes
        var bytes = _reports.ExcelProductoStock(dataDto, filtroTexto);

        // 4. Nombre del archivo con fecha para que no se sobrescriban
        var fileName = $"Stock_{DateTime.Now:yyyyMMdd_HHmm}.xlsx";

        // 5. Retornar el archivo correctamente
        return File(
            bytes,
            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
            fileName
        );
    }
    [HttpGet("stock/pdf")]
    public async Task<IActionResult> PdfProductoStock(
        [FromQuery] string? q = null,
        [FromQuery] string? categoria = null,
        [FromQuery] string? estado = null,
        [FromQuery] string? sort = "codigo")
    {
        //  Obtenemos los datos
        var (items, _) = await _kardex.ObtenerExistencias(q, categoria, estado, 1, 5000,null);
        //Lógica para el título dinámico
        string filtroTexto = "TODAS LAS CATEGORÍAS";

        if (!string.IsNullOrEmpty(categoria) && categoria != "TODAS")
        {
            filtroTexto = $"CATEGORÍA: {categoria.ToUpper()}";
        }

        if (!string.IsNullOrEmpty(estado) && estado.Equals("true", StringComparison.OrdinalIgnoreCase))
        {
            filtroTexto += " | SOLO PRODUCTOS CON STOCK";
        }
        
        // Aplicamos el ordenamiento antes de generar el PDF
        var query = items.AsQueryable();

        query = sort switch
        {
            "descripcion" => query.OrderBy(x => x.Descripcion),
            "codigo" => query.OrderBy(x => x.Codigo),
            "existencia" => query.OrderBy(x => x.Existencia),
            // Por si acaso el usuario quiere el orden inverso en algún momento:
            "existencia_desc" => query.OrderByDescending(x => x.Existencia),
            _ => query.OrderBy(x => x.Codigo) // El default siempre es bueno
        };
            if (!string.IsNullOrEmpty(estado) && estado.Equals("true", StringComparison.OrdinalIgnoreCase))
    {
        query = query.Where(x => x.Existencia > 0);
    }
        var dataDto = query.Select(x => new ProductoDTO
        {
            Codigo = x.Codigo,
            Descripcion = x.Descripcion,
            Categoria = x.Categoria,
            Existencia = (decimal)x.Existencia,
            PrecioVenta = (decimal)x.Precio,
            StockMinimo = (decimal)x.StockMinimo,
            UnidadMedida = x.Unidad
        }).ToList();

        var bytes = _reports.PdfProductoStock(dataDto, filtroTexto);
        return File(bytes, "application/pdf", $"Stock_{DateTime.Now:yyyyMMdd}.pdf");
    }

    // ── Dashboard KPIs
    [HttpGet("dashboard-stats")]
    public async Task<IActionResult> GetDashboardKPIs([FromQuery] DateTime desde, [FromQuery] DateTime hasta)
    {
        var stats = await _kardex.ObtenerDashboardCompleto(desde, hasta);
        return Ok(stats);
    }

    // ── Ventas diarias


    // stock
    [HttpGet("stock-productos")]
    public async Task<IActionResult> GetStockProductos()
    {
        try
        {
            var productos = await _kardex.ObtenerStockProductos();
            if (productos == null)
                return Ok(new List<ProductoDTO>());

            return Ok(productos);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Error al obtener el stock de productos: " + ex.Message);
        }

    }

  
}
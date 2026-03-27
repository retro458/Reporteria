using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReportesAPI.Data;
using ReportesAPI.Services;
using ReportesAPI.Models;

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
        if (string.IsNullOrWhiteSpace(q) || q.Length < 2)
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

        var (items, totales) = await _kardex.ObtenerExistencias(q, categoria, estado, pagina, size);

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
        var resultado = await _kardex.ObtenerExistencias(q, null, null, 1, 10000);

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
        var resultado = await _kardex.ObtenerExistencias(q, null, null, 1, 10000);

        var bytes = _reports.PdfExistencias(resultado.Items);

        return File(bytes, "application/pdf", $"Existencias_{DateTime.Now:yyyyMMdd}.pdf");
    }

    // Excel kardex general
    [HttpGet("general/excel")]
    public async Task<IActionResult> ExcelKardexGeneral(
    [FromQuery] DateTime desde, [FromQuery] DateTime hasta, [FromQuery] string? q = null)
    {
        var data = await _kardex.ObtenerKardexGeneral(desde, hasta, q);
        var bytes = _reports.ExcelKardexGeneral(data, desde, hasta);
        return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
            $"KardexGeneral_{desde:yyyyMMdd}_{hasta:yyyyMMdd}.xlsx");
    }

    [HttpGet("general/pdf")]
    public async Task<IActionResult> PdfKardexGeneral(
        [FromQuery] DateTime desde, [FromQuery] DateTime hasta, [FromQuery] string? q = null)
    {
        var data = await _kardex.ObtenerKardexGeneral(desde, hasta, q);
        var bytes = _reports.PdfKardexGeneral(data, desde, hasta);
        return File(bytes, "application/pdf",
            $"KardexGeneral_{desde:yyyyMMdd}_{hasta:yyyyMMdd}.pdf");
    }

    // ── Dashboard KPIs
    [HttpGet("dashboard-stats")]
    public async Task<IActionResult> GetDashboardKPIs([FromQuery] DateTime desde, [FromQuery] DateTime hasta)
    {
        var stats = await _kardex.ObtenerDashboardKPIs(desde, hasta);
      return Ok(stats);
    }

     // ── Ventas diarias

}
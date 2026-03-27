using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ReportesAPI.Data;
using ReportesAPI.Models;

namespace ReportesAPI.Services;

public class KardexService : IKardexService
{
    private readonly ControlDTEContext _db;
    private readonly ILogger<KardexService> _logger;

    public KardexService(ControlDTEContext db, ILogger<KardexService> logger)
    {
        _db = db;
        _logger = logger;
    }

    public async Task<KardexResult> ObtenerKardex(string codigo, DateTime desde, DateTime hasta)
    {
        try
        {
            // 1. SALDO INICIAL
            codigo = codigo.Trim();
            _logger.LogInformation("Calculando saldo inicial para producto {Codigo} desde {Desde}", codigo, desde);
            var saldoInicial = await _db.Database.SqlQueryRaw<double?>(@"
                SELECT SUM(Entrada - Salida)  AS Value
                FROM (
                    SELECT CAST(vd.Cantidad AS float) AS Salida, 0.0 AS Entrada
                    FROM Ventas v 
                    INNER JOIN Ventas_detalles vd ON v.VentaId = vd.VentaId
                    WHERE v.Eliminado = 0 AND v.Invalidado = 0 
                      AND vd.Productocodigo = @codigo AND v.Fecha < @desde
                      AND v.Documento NOT LIKE '%Remisión%' 
                    UNION ALL
                    SELECT 0.0 AS Salida, CAST(cd.Cantidad AS float) AS Entrada
                    FROM Compras c 
                    INNER JOIN Compras_detalles cd ON c.Numero = cd.Numero
                    WHERE c.Eliminado = 0 AND cd.Codigo = @codigo AND c.Fecha < @desde
                ) AS Historico",
                new SqlParameter("@codigo", codigo),
                new SqlParameter("@desde", desde.Date)).FirstOrDefaultAsync() ?? 0.0;

            // 2. MOVIMIENTOS DETALLADOS
            var movimientos = await _db.Database.SqlQueryRaw<KardexRow>(@"
                SELECT Fecha, Documento, Correlativo, ClienteProveedor, Salida, Entrada, Costo, 
                       CAST(0.0 AS float) AS SaldoAcumulado
                FROM (
                    SELECT 
                        v.Fecha, v.Documento, 
                        ISNULL(NULLIF(v.Correlativo, ''), 'ID-' + CAST(v.VentaId AS varchar)) AS Correlativo,
                        v.Cliente AS ClienteProveedor, 
                        CAST(ISNULL(vd.Cantidad, 0) AS float) AS Salida, 0.0 AS Entrada, 
                        CAST(ISNULL(p.CostoPromedio, ISNULL(p.Costo, 0)) AS float) AS Costo
                    FROM Ventas v
                    INNER JOIN Ventas_detalles vd ON v.VentaId = vd.VentaId
                    LEFT JOIN Productos p ON p.Codigo = vd.Productocodigo
                    WHERE v.Eliminado = 0 AND v.Invalidado = 0 
                      AND vd.Productocodigo = @codigo
                      AND v.Documento NOT LIKE '%Remisión%'
                      AND v.Fecha BETWEEN @desde AND @hasta
                    UNION ALL
                    SELECT 
                        CAST(c.Fecha AS datetime), c.Documento, c.Correlativo, c.Proveedor AS ClienteProveedor, 
                        0.0 AS Salida, CAST(ISNULL(cd.Cantidad, 0) AS float) AS Entrada, 
                        CAST(ISNULL(cd.Precio_uni, 0) AS float) AS Costo 
                    FROM Compras c
                    INNER JOIN Compras_detalles cd ON c.Numero = cd.Numero
                    WHERE c.Eliminado = 0 AND cd.Codigo = @codigo
                      AND c.Fecha BETWEEN @desde AND @hasta
                ) AS Movimientos
                ORDER BY Fecha ASC, Correlativo ASC",
                new SqlParameter("@codigo", codigo),
                new SqlParameter("@desde", desde.Date),
                new SqlParameter("@hasta", hasta.Date)).ToListAsync();

            double saldoAcumulado = saldoInicial;
            foreach (var mov in movimientos)
            {
                saldoAcumulado += (mov.Entrada - mov.Salida);
                mov.SaldoAcumulado = saldoAcumulado;
            }

            return new KardexResult
            {
                SaldoInicial = saldoInicial,
                Movimientos = movimientos.OrderByDescending(m => m.Fecha).ThenByDescending(m => m.Correlativo).ToList()
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al obtener kardex para producto {Codigo} desde {Desde} hasta {Hasta}", codigo, desde, hasta);
            throw;
        }
    }

    public async Task<List<KardexGeneralRow>> ObtenerKardexGeneral(DateTime desde, DateTime hasta, string? q = null)
    {
        var pQ = new SqlParameter("@q", string.IsNullOrWhiteSpace(q) ? (object)DBNull.Value : $"%{q}%");

        var sql = @"
            SELECT Fecha, Codigo, Descripcion, Documento, Correlativo, ClienteProveedor, Salida, Entrada, 
                   CAST(0.0 AS float) AS SaldoAcumulado, Costo
            FROM (
                SELECT 
                    v.Fecha, vd.Productocodigo AS Codigo, p.Descripcion, v.Documento, 
                    ISNULL(NULLIF(v.Correlativo, ''), 'ID-' + CAST(v.VentaId AS varchar)) AS Correlativo,
                    v.Cliente AS ClienteProveedor, 
                    CAST(ISNULL(vd.Cantidad, 0) AS float) AS Salida, 0.0 AS Entrada,
                    CAST(COALESCE(p.CostoPromedio, p.Costo, 0) AS float) AS Costo
                FROM Ventas v
                INNER JOIN Ventas_detalles vd ON v.VentaId = vd.VentaId
                LEFT JOIN Productos p ON p.Codigo = vd.Productocodigo
                WHERE v.Eliminado = 0 AND v.Invalidado = 0 
                  AND v.Fecha BETWEEN @desde AND @hasta
                  AND v.Documento NOT LIKE '%Remisión%'
                  AND vd.Productocodigo IS NOT NULL AND vd.Productocodigo <> ''
                UNION ALL
                SELECT 
                    CAST(c.Fecha AS datetime), cd.Codigo AS Codigo, p.Descripcion, c.Documento, c.Correlativo,
                    c.Proveedor AS ClienteProveedor, 0.0 AS Salida, CAST(ISNULL(cd.Cantidad, 0) AS float) AS Entrada,
                    CAST(ISNULL(cd.Precio_uni, 0) AS float) AS Costo
                FROM Compras c
                INNER JOIN Compras_detalles cd ON c.Numero = cd.Numero
                LEFT JOIN Productos p ON p.Codigo = cd.Codigo
                WHERE c.Eliminado = 0 AND c.Fecha BETWEEN @desde AND @hasta
                  AND cd.Codigo IS NOT NULL AND cd.Codigo <> ''
            ) AS Resultado
            WHERE (@q IS NULL OR Codigo LIKE @q OR Descripcion LIKE @q)
            ORDER BY Fecha ASC, Codigo ASC";

        var movimientos = await _db.Database.SqlQueryRaw<KardexGeneralRow>(sql,
            new SqlParameter("@desde", desde.Date),
            new SqlParameter("@hasta", hasta.Date), pQ).ToListAsync();

        var saldosTemporales = new Dictionary<string, double>();
        foreach (var mov in movimientos)
        {
            if (!saldosTemporales.ContainsKey(mov.Codigo ?? String.Empty)) saldosTemporales[mov.Codigo ?? String.Empty] = 0;
            saldosTemporales[mov.Codigo ?? String.Empty] += (mov.Entrada - mov.Salida);
            mov.SaldoAcumulado = saldosTemporales[mov.Codigo ?? String.Empty];
        }

        return movimientos.OrderByDescending(m => m.Fecha).ThenBy(m => m.Codigo).ToList();
    }

    public async Task<(List<ExistenciaRow> Items, IKardexService.ExistenciaTotals Totales)> ObtenerExistencias(
        string? q = null, string? categoria = null, string? estado = null, int pagina = 1, int registrosPorPagina = 50)
    {
        var queryBase = _db.Productos.Where(p => p.Eliminado == false && p.Suspendido == false);

        if (!string.IsNullOrEmpty(q)) queryBase = queryBase.Where(p => p.Codigo!.Contains(q) || p.Descripcion!.Contains(q));
        if (!string.IsNullOrEmpty(categoria)) queryBase = queryBase.Where(p => p.Categoria == categoria);

        if (estado == "ok") queryBase = queryBase.Where(p => p.Existencia > p.Stockminimo);
        else if (estado == "bajo") queryBase = queryBase.Where(p => p.Existencia > 0 && p.Existencia <= p.Stockminimo && p.Stockminimo > 0);
        else if (estado == "sin") queryBase = queryBase.Where(p => p.Existencia <= 0);

        var totales = new IKardexService.ExistenciaTotals(
            Total: await queryBase.CountAsync(),
            EnStock: await queryBase.CountAsync(p => p.Existencia > p.Stockminimo),
            BajoMinimo: await queryBase.CountAsync(p => p.Existencia > 0 && p.Existencia <= p.Stockminimo && p.Stockminimo > 0),
            SinStock: await queryBase.CountAsync(p => p.Existencia <= 0)
        );

        var skip = (pagina - 1) * registrosPorPagina;
        var pQ = new SqlParameter("@q", string.IsNullOrWhiteSpace(q) ? "%" : $"%{q}%");

        var items = await _db.Database.SqlQueryRaw<ExistenciaRow>(@"
            SELECT Codigo, Descripcion, Categoria, Unidaddemedida AS Unidad,
                   CAST(ISNULL(Stockminimo, 0) AS float) AS StockMinimo,
                   CAST(ISNULL(Existencia, 0) AS float) AS Existencia,
                   CAST(ISNULL(CostoPromedio, ISNULL(Costo, 0)) AS float) AS CostoPromedio,
                   CAST(ISNULL(Preciouno, 0) AS float) AS Precio, Proveedor
            FROM Productos
            WHERE Eliminado = 0 AND Suspendido = 0
              AND (Codigo LIKE @q OR Descripcion LIKE @q)"
              + (string.IsNullOrEmpty(categoria) ? "" : $" AND Categoria = '{categoria}'")
              + " ORDER BY Descripcion OFFSET " + skip + " ROWS FETCH NEXT " + registrosPorPagina + " ROWS ONLY", pQ).ToListAsync();

        return (items, totales);
    }

    public async Task<DashboardKPIs> ObtenerDashboardKPIs(DateTime desde, DateTime hasta)
    {
        try
        {
            var resultado = await _db.Database.SqlQueryRaw<DashboardKPIs>(
                "EXEC dbo.sp_GetDashboardStats @desde, @hasta",
                new SqlParameter("@desde", desde.Date),
                new SqlParameter("@hasta", hasta.Date)
            ).ToListAsync();

            var kpis = resultado.FirstOrDefault();

            if (kpis != null)
            {
                kpis.InversionComprasPeriodo = Math.Round(kpis.InversionComprasPeriodo, 2);
                kpis.ValorVentasPeriodo = Math.Round(kpis.ValorVentasPeriodo, 2);
            }
            return kpis ?? new DashboardKPIs();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al obtener KPIs para el dashboard desde {Desde} hasta {Hasta}", desde, hasta);
            throw;
        }
      
    }

}
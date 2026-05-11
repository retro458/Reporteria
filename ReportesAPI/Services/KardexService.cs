using System.Data;
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
        codigo = codigo.Trim();
        var fechaDesde = desde.Date; 
        var fechaHasta = hasta.Date.AddDays(1).AddTicks(-1);

        // 1. SALDO INICIAL (Mantenemos la lógica de limpieza)
        var saldoInicial = await _db.Database.SqlQueryRaw<double?>(@"
            SELECT SUM(Entrada - Salida) AS Value
            FROM (
                SELECT CAST(vd.Cantidad AS float) AS Salida, 0.0 AS Entrada 
                FROM Ventas v 
                INNER JOIN Ventas_detalles vd ON v.VentaId = vd.VentaId
                WHERE v.Eliminado = 0 AND v.Invalidado = 0 
                  AND LTRIM(RTRIM(vd.Productocodigo)) = @codigo 
                  AND v.Fecha < @desde 
                  AND v.Documento NOT LIKE '%Remisión%'
                
                UNION ALL
                
                SELECT 0.0 AS Salida, CAST(cd.Cantidad AS float) AS Entrada 
                FROM Compras c 
                INNER JOIN Compras_detalles cd ON c.Numero = cd.Numero
                WHERE c.Eliminado = 0 
                  AND LTRIM(RTRIM(cd.Codigo)) = @codigo 
                  AND c.Fecha < @desde
                
                UNION ALL
                
                SELECT 
                    CASE WHEN ad.Documento_codigo = '50' THEN ABS(CAST(ad.Cantidad AS float)) ELSE 0.0 END AS Salida,
                    CASE WHEN ad.Documento_codigo = '51' THEN ABS(CAST(ad.Cantidad AS float)) ELSE 0.0 END AS Entrada
                FROM Ajustes_detalles ad
                INNER JOIN Ajustes a ON LTRIM(RTRIM(ad.Numero)) = LTRIM(RTRIM(a.Numero))
                WHERE LTRIM(RTRIM(ad.Codigo)) = @codigo 
                  AND a.Fecha < @desde 
                  AND a.Cancelada = 1
            ) AS Historico",
            new SqlParameter("@codigo", codigo),
            new SqlParameter("@desde", fechaDesde)).FirstOrDefaultAsync() ?? 0.0;

        // 2. MOVIMIENTOS: Lógica corregida para mostrar Documento y Correlativo real de Compras
        var movimientos = await _db.Database.SqlQueryRaw<KardexRow>(@"
            SELECT Fecha, Codigo, Documento, Correlativo, ClienteProveedor, Salida, Entrada, Costo, CAST(0.0 AS float) AS SaldoAcumulado
            FROM (
                SELECT v.Fecha, vd.Productocodigo AS Codigo, v.Documento, 
                       ISNULL(NULLIF(CAST(v.Correlativo AS varchar), ''), CAST(v.VentaId AS varchar)) AS Correlativo,
                       ISNULL(v.Cliente, '') AS ClienteProveedor, 
                       CAST(vd.Cantidad AS float) AS Salida, 0.0 AS Entrada, 
                       CAST(ISNULL(vd.Precio_uni, 0) AS float) AS Costo
                FROM Ventas v 
                INNER JOIN Ventas_detalles vd ON v.VentaId = vd.VentaId
                WHERE v.Eliminado = 0 AND v.Invalidado = 0 
                  AND LTRIM(RTRIM(vd.Productocodigo)) = @codigo 
                  AND v.Fecha BETWEEN @desde AND @hasta 
                  AND v.Documento NOT LIKE '%Remisión%'
                
                UNION ALL
                
                /* CAMBIO AQUÍ: Traemos Documento y Correlativo de la tabla Compras */
                SELECT c.Fecha, cd.Codigo, 
                       ISNULL(NULLIF(c.Documento, ''), 'COMPRA') AS Documento, 
                       ISNULL(NULLIF(CAST(c.Correlativo AS varchar), ''), CAST(c.Numero AS varchar)) AS Correlativo, 
                       ISNULL(c.Proveedor, '') AS ClienteProveedor, 
                       0.0 AS Salida, CAST(cd.Cantidad AS float) AS Entrada, 
                       CAST(ISNULL(cd.Precio_uni, 0) AS float) AS Costo
                FROM Compras c 
                INNER JOIN Compras_detalles cd ON c.Numero = cd.Numero
                WHERE c.Eliminado = 0 
                  AND LTRIM(RTRIM(cd.Codigo)) = @codigo 
                  AND c.Fecha BETWEEN @desde AND @hasta

                UNION ALL

                SELECT CAST(a.Fecha AS datetime) AS Fecha, ad.Codigo, 
                    CASE 
                        WHEN ad.Documento_codigo = '50' THEN 'AJUSTE DE SALIDA'
                        WHEN ad.Documento_codigo = '51' THEN 'AJUSTE DE ENTRADA'
                        ELSE 'AJUSTE INVENTARIO' 
                    END AS Documento, 
                    CAST(a.Numero AS varchar) AS Correlativo,
                    ISNULL(CAST(a.Referencia AS varchar), 'Ajuste Manual') AS ClienteProveedor,
                    CASE WHEN ad.Documento_codigo = '50' THEN ABS(CAST(ad.Cantidad AS float)) ELSE 0.0 END AS Salida,
                    CASE WHEN ad.Documento_codigo = '51' THEN ABS(CAST(ad.Cantidad AS float)) ELSE 0.0 END AS Entrada,
                    CAST(ISNULL(ad.Precio_uni, 0) AS float) AS Costo
                FROM Ajustes_detalles ad
                INNER JOIN Ajustes a ON LTRIM(RTRIM(ad.Numero)) = LTRIM(RTRIM(a.Numero))
                WHERE LTRIM(RTRIM(ad.Codigo)) = @codigo 
                  AND a.Fecha BETWEEN @desde AND @hasta
                  AND a.Cancelada = 1
            ) AS Movimientos
            ORDER BY Fecha ASC, Correlativo ASC",
            new SqlParameter("@codigo", codigo),
            new SqlParameter("@desde", fechaDesde),
            new SqlParameter("@hasta", fechaHasta)).ToListAsync();

        double saldoAcumulado = saldoInicial;
        foreach (var mov in movimientos)
        {
            saldoAcumulado += (mov.Entrada - mov.Salida);
            mov.SaldoAcumulado = saldoAcumulado;
        }

        return new KardexResult { SaldoInicial = saldoInicial, Movimientos = movimientos };
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error en Kardex para {Codigo}", codigo);
        throw;
    }
}
public async Task<List<KardexGeneralRow>> ObtenerKardexGeneral(DateTime desde, DateTime hasta, string? q = null, string? tipoDocumento = null, string? sort = null)
{
    var pQ = new SqlParameter("@q", string.IsNullOrWhiteSpace(q) ? (object)DBNull.Value : $"%{q}%");

    string filtroDoc = tipoDocumento?.ToUpper() switch {
        "FACTURA" => "FACTURA",
        "CREDITO" => "FISCAL", 
        "AJUSTE" => "AJUSTE",
        _ => "" 
    };
    var pDoc = new SqlParameter("@filtroDoc", string.IsNullOrEmpty(filtroDoc) ? (object)DBNull.Value : $"%{filtroDoc}%");

    var sql = @"
        SELECT * FROM (
            SELECT Fecha, Codigo, Descripcion, Documento, Correlativo, ClienteProveedor, Salida, Entrada, 
                   CAST(0.0 AS float) AS SaldoAcumulado, Costo
            FROM (
                /* 1. VENTAS */
                SELECT 
                    v.Fecha, vd.Productocodigo AS Codigo, p.Descripcion, v.Documento, 
                    ISNULL(NULLIF(v.Correlativo, ''), CAST(v.VentaId AS varchar)) AS Correlativo,
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

                /* 2. COMPRAS */
                SELECT 
                    CAST(c.Fecha AS datetime), cd.Codigo AS Codigo, p.Descripcion, c.Documento, c.Correlativo,
                    c.Proveedor AS ClienteProveedor, 0.0 AS Salida, CAST(ISNULL(cd.Cantidad, 0) AS float) AS Entrada,
                    CAST(ISNULL(cd.Precio_uni, 0) AS float) AS Costo
                FROM Compras c
                INNER JOIN Compras_detalles cd ON c.Numero = cd.Numero
                LEFT JOIN Productos p ON p.Codigo = cd.Codigo
                WHERE c.Eliminado = 0 AND c.Fecha BETWEEN @desde AND @hasta
                  AND cd.Codigo IS NOT NULL AND cd.Codigo <> ''

                UNION ALL

                /* 3. AJUSTES - Lógica corregida con JOIN */
                SELECT 
                    CAST(a.Fecha AS datetime) AS Fecha, 
                    LTRIM(RTRIM(ad.Codigo)) AS Codigo, 
                    ISNULL(p.Descripcion, ad.Nombre) AS Descripcion, 
                    CASE 
                        WHEN ad.Documento_codigo = '50' THEN 'AJUSTE DE SALIDA'
                        WHEN ad.Documento_codigo = '51' THEN 'AJUSTE DE ENTRADA'
                        ELSE 'AJUSTE INVENTARIO' 
                    END AS Documento, 
                    CAST(a.Numero AS varchar) AS Correlativo,
                    ISNULL(NULLIF(CAST(a.Referencia AS varchar), ''), 'Ajuste Manual') AS ClienteProveedor,
                    -- Forzamos salida si es código 50
                    CASE WHEN ad.Documento_codigo = '50' THEN ABS(CAST(ad.Cantidad AS float)) ELSE 0.0 END AS Salida,
                    -- Forzamos entrada si es código 51
                    CASE WHEN ad.Documento_codigo = '51' THEN ABS(CAST(ad.Cantidad AS float)) ELSE 0.0 END AS Entrada,
                    CAST(ISNULL(ad.Precio, 0) AS float) AS Costo
                FROM Ajustes_detalles ad
                INNER JOIN Ajustes a ON LTRIM(RTRIM(ad.Numero)) = LTRIM(RTRIM(a.Numero))
                LEFT JOIN Productos p ON LTRIM(RTRIM(p.Codigo)) = LTRIM(RTRIM(ad.Codigo))
                WHERE ad.Codigo IS NOT NULL AND ad.Codigo <> ''
                  AND a.Fecha BETWEEN @desde AND @hasta
                  AND a.Cancelada = 1 -- Solo movimientos no anulados

            ) AS Sub
            WHERE (@q IS NULL OR Codigo LIKE @q OR Descripcion LIKE @q)
              AND (@filtroDoc IS NULL OR Documento LIKE @filtroDoc)
        ) AS Resultado
        ORDER BY Fecha ASC, Codigo ASC";

    var movimientos = await _db.Database.SqlQueryRaw<KardexGeneralRow>(sql,
        new SqlParameter("@desde", desde.Date),
        new SqlParameter("@hasta", hasta.Date), 
        pQ, 
        pDoc).ToListAsync();

    // Lógica de saldos acumulados por producto
    var saldosTemporales = new Dictionary<string, double>();
    foreach (var mov in movimientos)
    {
        string key = mov.Codigo ?? string.Empty;
        if (!saldosTemporales.ContainsKey(key)) saldosTemporales[key] = 0;
        
        saldosTemporales[key] += (mov.Entrada - mov.Salida);
        mov.SaldoAcumulado = saldosTemporales[key];
    }

    return sort switch
    {
        "fecha_asc" => movimientos.OrderBy(m => m.Fecha).ThenBy(m => m.Codigo).ToList(),
        "codigo_antiguo" => movimientos.OrderBy(m => m.Codigo).ThenBy(m => m.Fecha).ToList(),
        "codigo_reciente" => movimientos.OrderBy(m => m.Codigo).ThenByDescending(m => m.Fecha).ToList(),
        _ => movimientos.OrderByDescending(m => m.Fecha).ThenBy(m => m.Codigo).ToList()
    };
}
    public async Task<(List<ExistenciaRow> Items, IKardexService.ExistenciaTotals Totales)> ObtenerExistencias(
        string? q = null, string? categoria = null, string? estado = null, int pagina = 1, int registrosPorPagina = 50, string? sort = "descripcion")
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
        string searchPattern = string.IsNullOrWhiteSpace(q) ? "%" : $"{q}%";
        var pQ = new SqlParameter("@q", searchPattern);
        //ordenamiento dinamico
        string sqlOrderBy = sort switch
    {
        "codigo" => "LEN(Codigo) ASC, Codigo ASC",
        "existencia_asc" => "Existencia ASC",
        "existencia_desc" => "Existencia DESC",
        _ => "Descripcion ASC"
    }; 
        // construccion de sql para filtrado
        var sqlFiltroEstado = "";
        if (estado == "ok") sqlFiltroEstado = " AND Existencia > Stockminimo";
        else if (estado == "bajo") sqlFiltroEstado = " AND Existencia > 0 AND Existencia <= Stockminimo AND Stockminimo > 0";
        else if (estado == "sin") sqlFiltroEstado = " AND Existencia <= 0";

        var skip = (pagina - 1) * registrosPorPagina;
        //busqueda mejorada 
        var sqlFiltroCat = string.IsNullOrEmpty(categoria) ? "" : " AND Categoria = @cat";
        
        var pCat = new SqlParameter("@cat", System.Data.SqlDbType.NVarChar) 
        { 
            Value = (object?)categoria ?? DBNull.Value 
        };
     var sql = $@"
        SELECT Codigo, Descripcion, Categoria, Unidaddemedida AS Unidad,
               CAST(ISNULL(Stockminimo, 0) AS float) AS StockMinimo,
               CAST(ISNULL(Existencia, 0) AS float) AS Existencia,
               CAST(ISNULL(CostoPromedio, ISNULL(Costo, 0)) AS float) AS CostoPromedio,
               CAST(ISNULL(Preciouno, 0) AS float) AS Precio, Proveedor
        FROM Productos
        WHERE Eliminado = 0 AND Suspendido = 0
          AND (Codigo LIKE @q OR Descripcion LIKE @q)
          {sqlFiltroCat} 
          {sqlFiltroEstado} 
        ORDER BY {sqlOrderBy} 
        OFFSET {skip} ROWS FETCH NEXT {registrosPorPagina} ROWS ONLY";
     
    var items = await _db.Database.SqlQueryRaw<ExistenciaRow>(sql, pQ, pCat).ToListAsync();

    return (items, totales);
    }
    public async Task<DashboardDataDTO> ObtenerDashboardCompleto(DateTime desde, DateTime hasta)
{
    var dto = new DashboardDataDTO {
        Totales = new DashboardKPIs(),
        TopFugas = new List<ProductoStockBajo>(),
        DatosGrafica = new List<VentaDiaria>()
    };

    using (var command = _db.Database.GetDbConnection().CreateCommand())
    {
        command.CommandText = "dbo.sp_GetDashboardStats";
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add(new SqlParameter("@desde", desde));
        command.Parameters.Add(new SqlParameter("@hasta", hasta));

        var con = command.Connection;
        if (con != null && con.State != ConnectionState.Open) await con.OpenAsync();

        using (var reader = await command.ExecuteReaderAsync())
        {
            // 1. KPIs (Ahora con desglose de IVA)
            if (await reader.ReadAsync())
            {
                dto.Totales.TotalProductos = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                dto.Totales.InversionComprasPeriodo = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);
                // Mapeo de los nuevos campos del SP
                dto.Totales.VentasBrutas = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2);
                dto.Totales.VentasNetas = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3);
                dto.Totales.IVAAcumulado = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4);
            }

            // 2. Top Fugas 
            await reader.NextResultAsync();
            while (await reader.ReadAsync())
            {
                dto.TopFugas.Add(new ProductoStockBajo {
                    Codigo = reader.GetString(0),
                    Descripcion = reader.GetString(1),
                    Existencia = reader.GetDecimal(2)
                });
            }

            // 3. Gráfica (Con series para Bruto, Neto e IVA)
            await reader.NextResultAsync();
            while (await reader.ReadAsync())
            {
                dto.DatosGrafica.Add(new VentaDiaria
                {
                    Fecha = reader.GetDateTime(0),
                    TotalBruto = Convert.ToDouble(reader.GetValue(1)),
                    TotalNeto = Convert.ToDouble(reader.GetValue(2)),
                    TotalIVA = Convert.ToDouble(reader.GetValue(3))
                });
            }
        }
    }
    return dto;
}

    // para obtener el stock de productos 
 public async Task<List<ProductoDTO>> ObtenerStockProductos()
{
    var lista = new List<ProductoDTO>();
    using (var command = _db.Database.GetDbConnection().CreateCommand())
    {
        command.CommandText = "dbo.sp_GetProductStock";
        command.CommandType = CommandType.StoredProcedure;

        var con = command.Connection;
            if (con != null)
            {
             if (con.State != ConnectionState.Open) await con.OpenAsync();
            }
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        lista.Add(new ProductoDTO
                        {
                            Codigo = reader.GetString(0),
                            Descripcion = reader.GetString(1),
                            Categoria = reader.GetString(2),
                            Existencia = reader.GetDecimal(3),
                            PrecioVenta = reader.GetDecimal(4),
                            StockMinimo = reader.GetDecimal(5),
                            UnidadMedida = reader.GetString(6)
                        });
                    }
                }
    }
    return lista;
}

}
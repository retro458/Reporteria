using ReportesAPI.Models;

/*
    @ Erick Baudriz: Esta interfaz define los métodos para obtener los datos del kardex y existencias.
    Se implementa en KardexService, donde se ejecutan consultas SQL directas para optimizar el rendimiento, especialmente al manejar grandes volúmenes de datos.


    @Author: Erick Baudriz
     Fecha: 2026-03-19
*/

namespace ReportesAPI.Services;

public interface IKardexService
{
    Task<KardexResult> ObtenerKardex(string codigo, DateTime desde, DateTime hasta); Task<List<KardexGeneralRow>> ObtenerKardexGeneral(DateTime desde, DateTime hasta, string? q = null, string? tipoDocumento = null, string? sort= null);

    public record ExistenciaTotals(int Total, int EnStock, int BajoMinimo, int SinStock);
    Task<(List<ExistenciaRow> Items, ExistenciaTotals Totales)> ObtenerExistencias(string? q = null, string? categoria = null, string? estado = null, int pagina = 1, int registrosPorPagina = 50, string? descripcion = null);

    //Task<DashboardKPIs> ObtenerDashboardKPIs(DateTime desde, DateTime hasta);
    Task<DashboardDataDTO> ObtenerDashboardCompleto(DateTime desde, DateTime hasta);

    //Task para obtener el stock de productos
    /* Task<List<ProductoDTO>> ObtenerStockProductos(string codigos,   string Descripcion, string Categoria,  decimal Existencia,
     decimal PrecioVenta,
     decimal StockMinimo, 
     string UnidadMedida);*/

    Task<List<ProductoDTO>> ObtenerStockProductos();
}

public class KardexResult
    {
    public double SaldoInicial { get; set; }
    public List<KardexRow> Movimientos { get; set; } = new();
    }
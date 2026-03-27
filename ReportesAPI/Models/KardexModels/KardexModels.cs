namespace ReportesAPI.Models;

/*
    @Erick Baudriz: Estas clases representan las filas de datos que se obtienen al consultar el kardex y las existencias.
    Se utilizan para mapear los resultados de las consultas SQL directas que se ejecutan en KardexService, optimizando el rendimiento al manejar grandes volúmenes de datos.


    @Author: Erick Baudriz
     Fecha: 2026-03-19
*/
public class KardexRow
{
    public DateTime Fecha { get; set; }
    public string Documento { get; set; } = "";
    public string Correlativo { get; set; } = "";
    public string ClienteProveedor { get; set; } = "";
    public double Salida { get; set; } 
    public double Entrada { get; set; }
    public double Costo { get; set; } 
    public double SaldoAcumulado { get; set; }
}

public class KardexGeneralRow
{
    public DateTime Fecha { get; set; }
    public string? Codigo { get; set; }
    public string? Descripcion { get; set; }
    public string? Documento { get; set; }
    public string? Correlativo { get; set; }
    public string? ClienteProveedor { get; set; }
    public double Entrada { get; set; }
    public double Salida { get; set; }
    public double Costo { get; set; }
    
    public double SaldoAcumulado { get; set; }
}

public class ExistenciaRow
{
    public string? Codigo { get; set; }
    public string? Descripcion { get; set; }
    public string? Categoria { get; set; }
    public string? Unidad { get; set; }
    public double StockMinimo { get; set; }
    public double Existencia { get; set; }
    public double CostoPromedio { get; set; }
    public double Precio { get; set; }
    public string? Proveedor { get; set; }
}


public class DashboardKPIs
{
    public int TotalProductos { get; set; }
    public decimal InversionComprasPeriodo { get; set; }
    public decimal ValorVentasPeriodo { get; set; }
}

public class VentaDiaria
{
    public DateTime Fecha { get; set; }
    public double TotalDia { get; set; }
}

public class DasboardResult
{
    public DashboardKPIs KPIs { get; set; } = new();
    public List<KardexGeneralRow> TopNegativos { get; set; } = new();
    public List<VentaDiaria> GraficaVentas { get; set; } = new();
}
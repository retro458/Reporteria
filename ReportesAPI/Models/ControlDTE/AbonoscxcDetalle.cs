using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class AbonoscxcDetalle
{
    public int AvonoscxcDetallesId { get; set; }

    public int? VentaId { get; set; }

    public string? Codigo { get; set; }

    public string? Correlativo { get; set; }

    public string? Documentocodigo { get; set; }

    public string? Productocodigo { get; set; }

    public string? Nombre { get; set; }

    public decimal? PrecioUni { get; set; }

    public decimal? Cantidad { get; set; }

    public decimal? Descuento { get; set; }

    public decimal? PrecioConIva { get; set; }

    public string? Almacenalias { get; set; }

    public string? Almacencodigo { get; set; }

    public decimal? Costo { get; set; }

    public string? PrecioFacturado { get; set; }

    public string? Proveedor { get; set; }

    public bool? Servicio { get; set; }

    public string? Facturacion { get; set; }

    public decimal? Costodeimportacion { get; set; }

    public bool? Serie { get; set; }

    public string? Referencia { get; set; }

    public decimal? Ventasexenta { get; set; }

    public decimal? Ventasafectas { get; set; }

    public decimal? Subtotal { get; set; }

    public decimal? Ventaexenta { get; set; }

    public decimal? Item { get; set; }

    public string? Barra { get; set; }

    public string? Unidaddemedida { get; set; }

    public string? Categoria { get; set; }

    public decimal? Nosujetas { get; set; }

    public decimal? Margen { get; set; }

    public string? Notaderemision { get; set; }

    public string? Facturaoccf { get; set; }

    public decimal? Preciosiniva { get; set; }

    public DateTime? Fechadecreacion { get; set; }

    public string? Usuario { get; set; }

    public decimal? ValorGanancia { get; set; }

    public decimal? PorcentajeGanancia { get; set; }

    public decimal? Preciosindescuento { get; set; }

    public string? Usuariocambioprecio { get; set; }

    public DateOnly? Fechahoracambioprecio { get; set; }

    public string? Justificacion { get; set; }

    public decimal? Comision { get; set; }

    public decimal? Valorcomision { get; set; }
}

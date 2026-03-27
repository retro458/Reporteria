using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class ComprasDetalle
{
    public int Id { get; set; }

    public string? Numero { get; set; }

    public string? Correlativo { get; set; }

    public string? DocumentoCodigo { get; set; }

    public string? Codigo { get; set; }

    public string? Nombre { get; set; }

    public decimal? PrecioUni { get; set; }

    public decimal? Cantidad { get; set; }

    public decimal? Total { get; set; }

    public decimal? PrecioConIva { get; set; }

    public decimal? Proveedorcodigo { get; set; }

    public decimal? Descuento { get; set; }

    public string? Cuenta { get; set; }

    public decimal? Precio { get; set; }

    public decimal? Credito { get; set; }

    public string? Codalmacen { get; set; }

    public string? Almacen { get; set; }

    public string? Proveedor { get; set; }

    public string? Categoria { get; set; }

    public decimal? Costodeimportacion { get; set; }

    public string? Descripciondecuenta { get; set; }

    public decimal? Costoanterior { get; set; }

    public decimal? Costofob { get; set; }

    public decimal? Precioanterior { get; set; }

    public DateOnly? Fechadevencimiento { get; set; }

    public decimal? Dai { get; set; }

    public decimal? Factorutilidad { get; set; }

    public decimal? Nuevoprecio { get; set; }

    public decimal? Subtotal { get; set; }

    public decimal? Costofonanterior { get; set; }

    public decimal? Exentas { get; set; }

    public string? Unidaddemedida { get; set; }

    public decimal? Ultimocosto { get; set; }

    public string? Marca { get; set; }

    public decimal? Cambio { get; set; }

    public decimal? Factor { get; set; }

    public decimal? Costocondai { get; set; }

    public decimal? Gastoexterior { get; set; }

    public decimal? Valorcif { get; set; }

    public decimal? Valorcifdai { get; set; }

    public decimal? Gastospoliza { get; set; }

    public decimal? Gastoslocales { get; set; }

    public decimal? Costototal { get; set; }

    public decimal? Costounitario { get; set; }

    public decimal? Preciodeventa { get; set; }

    public string? Orden { get; set; }

    public string? Placas { get; set; }

    public decimal? Valordescuento { get; set; }

    public string? Lote { get; set; }

    public DateOnly? Fecha { get; set; }

    public DateTime? Fechadecreacion { get; set; }

    public DateOnly? Fechad { get; set; }

    public bool? Seleccionada { get; set; }

    public string? Referencia { get; set; }
}

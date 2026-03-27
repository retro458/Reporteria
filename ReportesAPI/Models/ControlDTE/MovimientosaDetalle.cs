using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class MovimientosaDetalle
{
    public int IdMovimientosaDet { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public string? Usuario { get; set; }

    public string? Numero { get; set; }

    public string? Correlativo { get; set; }

    public string? Codigodedocumento { get; set; }

    public string? Documento { get; set; }

    public string? Descripcion { get; set; }

    public decimal? Cantidad { get; set; }

    public string? Codigodeproducto { get; set; }

    public string? Codigodealmacende { get; set; }

    public string? Almacenpara { get; set; }

    public string? Codigodealmacen { get; set; }

    public decimal? Valor { get; set; }

    public string? Proveedor { get; set; }

    public decimal? Tiempodecredito { get; set; }

    public string? Categoria { get; set; }

    public decimal? Costodeimportacion { get; set; }

    public bool? Serie { get; set; }

    public string? Almacende { get; set; }

    public decimal? Precio { get; set; }

    public decimal? Costo { get; set; }

    public decimal? Total { get; set; }

    public DateOnly? Fechad { get; set; }

    public decimal? Item { get; set; }
}

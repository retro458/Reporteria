using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Distribucion
{
    public int Id { get; set; }

    public DateTime? FechadeCreacion { get; set; }

    public string? Usuario { get; set; }

    public string? Codigo { get; set; }

    public string? Almacen { get; set; }

    public string? CodigoAlmacen { get; set; }

    public decimal? ExistenciaEnAlmacen { get; set; }

    public string? CodigoProducto { get; set; }

    public decimal? Stockminimo { get; set; }

    public decimal? Stockmaximo { get; set; }

    public decimal? Inicial { get; set; }

    public decimal? Costoinicial { get; set; }

    public DateOnly? Ultimomovimiento { get; set; }

    public string? Concepto { get; set; }

    public decimal? Costo { get; set; }

    public string? Lote { get; set; }

    public DateOnly? Fechadevencimiento { get; set; }

    public DateOnly? Fechadecompra { get; set; }

    public string? Documento { get; set; }

    public decimal? Ajuste { get; set; }

    public DateOnly? Fechadeajuste { get; set; }

    public DateOnly? Fecha { get; set; }
}

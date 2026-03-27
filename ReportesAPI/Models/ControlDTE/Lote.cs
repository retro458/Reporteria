using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Lote
{
    public int Id { get; set; }

    public string? Codigodeproducto { get; set; }

    public string? Lote1 { get; set; }

    public DateOnly? Vencimiento { get; set; }

    public decimal? Cantidad { get; set; }

    public decimal? Existencia { get; set; }

    public string? Keydocumento { get; set; }

    public DateTime? Creado { get; set; }

    public decimal? Seleccionado { get; set; }

    public string? Ubicacion { get; set; }
}

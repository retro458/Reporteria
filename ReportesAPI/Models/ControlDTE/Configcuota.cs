using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Configcuota
{
    public int Id { get; set; }

    public string? Categoria { get; set; }

    public string? Prefijo { get; set; }

    public decimal? Membresia { get; set; }

    public bool? Pagamembresia { get; set; }

    public decimal? Cuota { get; set; }

    public decimal? Donacion { get; set; }

    public bool? Pagadonacion { get; set; }

    public decimal? Donacioncasacomp { get; set; }
}

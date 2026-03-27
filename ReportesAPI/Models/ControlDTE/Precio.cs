using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Precio
{
    public int Id { get; set; }

    public string Codigodeproducto { get; set; } = null!;

    public string Presentacion { get; set; } = null!;

    public decimal? Precio1 { get; set; }

    public decimal? Factor { get; set; }

    public string Descripcionpresentacion { get; set; } = null!;

    public string? Codigoanterior { get; set; }

    public string? Codigonuevo { get; set; }

    public DateTime? Creado { get; set; }

    public string Usuario { get; set; } = null!;
}

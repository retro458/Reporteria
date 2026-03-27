using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Inventario
{
    public int Id { get; set; }

    public int? Inventario1 { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? Encargado { get; set; }

    public string? Tipo { get; set; }

    public string? Clasificacion { get; set; }

    public string? Filtro { get; set; }

    public bool? Activo { get; set; }
}

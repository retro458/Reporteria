using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Empleado
{
    public int EmpleadoId { get; set; }

    public string? Codigo { get; set; }

    public string? Nombre { get; set; }

    public string? Alias { get; set; }
}

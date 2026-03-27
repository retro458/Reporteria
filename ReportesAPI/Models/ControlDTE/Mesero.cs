using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Mesero
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public string? Nombre { get; set; }

    public string? Codigodeempleado { get; set; }

    public string? Contraseña { get; set; }

    public string? Cargo { get; set; }
}

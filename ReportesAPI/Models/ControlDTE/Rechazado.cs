using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Rechazado
{
    public int Id { get; set; }

    public DateTime? Creado { get; set; }

    public string? Respuesta { get; set; }
}

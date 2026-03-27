using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Documento
{
    public int IdDocumento { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public int? Codigo { get; set; }

    public string? Documento1 { get; set; }
}

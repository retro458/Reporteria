using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Correlativo
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public int? Ultimo { get; set; }
}

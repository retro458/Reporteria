using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Reporte
{
    public int IdReporte { get; set; }

    public string? Descripcion { get; set; }

    public string? Nombre { get; set; }

    public string? Modulo { get; set; }
}

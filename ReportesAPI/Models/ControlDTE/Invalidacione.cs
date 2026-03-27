using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Invalidacione
{
    public int InvalidacionesId { get; set; }

    public string? Codigo { get; set; }

    public decimal? Version { get; set; }

    public string? Ambiente { get; set; }

    public string? Codigogeneracion { get; set; }

    public string? Fecanula { get; set; }

    public string? Horanula { get; set; }

    public string? Json { get; set; }

    public string? Jsonfirmado { get; set; }

    public string? Respuesta { get; set; }

    public string? Jsonenviado { get; set; }

    public bool? Procesado { get; set; }
}

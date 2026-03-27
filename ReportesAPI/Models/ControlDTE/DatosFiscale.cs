using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class DatosFiscale
{
    public int IdDatosFiscales { get; set; }

    public int IdEmpresa { get; set; }

    public DateTime Fechadecreacion { get; set; }

    public string Nit { get; set; } = null!;

    public string Dui { get; set; } = null!;

    public string Giro { get; set; } = null!;

    public string RepresentanteLegal { get; set; } = null!;

    public string Contador { get; set; } = null!;

    public string NoInscripcionContador { get; set; } = null!;

    public string Auditor { get; set; } = null!;

    public string NoInscriptorAuditor { get; set; } = null!;
}

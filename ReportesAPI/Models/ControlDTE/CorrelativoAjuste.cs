using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class CorrelativoAjuste
{
    public int Idcorrelativoajuste { get; set; }

    public int? Inventariono { get; set; }

    public int? Ajusteno { get; set; }

    public bool? Activo { get; set; }
}

using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Reinicio
{
    public int ReiniciosId { get; set; }

    public decimal? Reyear { get; set; }

    public bool? Aplicado { get; set; }
}

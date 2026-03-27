using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Cuenta
{
    public int Id { get; set; }

    public string? Orde { get; set; }

    public decimal? Numero { get; set; }

    public decimal? Valor { get; set; }
}

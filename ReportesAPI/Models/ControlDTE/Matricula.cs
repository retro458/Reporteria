using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Matricula
{
    public int Id { get; set; }

    public string? Nivel { get; set; }

    public decimal? Valor { get; set; }

    public string? Codigo { get; set; }
}

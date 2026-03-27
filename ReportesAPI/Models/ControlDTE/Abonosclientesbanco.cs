using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Abonosclientesbanco
{
    public int Id { get; set; }

    public string? Referencia { get; set; }

    public string? Banco { get; set; }

    public string? Cuentacontable { get; set; }

    public decimal? Valor { get; set; }
}

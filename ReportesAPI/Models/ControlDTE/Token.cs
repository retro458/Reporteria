using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Token
{
    public string? Codigo { get; set; }

    public DateTime? Creado { get; set; }

    public string? Token1 { get; set; }

    public int Numero { get; set; }

    public string? Usuario { get; set; }

    public DateTime? Fecha { get; set; }
}

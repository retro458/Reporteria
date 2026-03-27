using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Submenu
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public string? Menuprincipal { get; set; }

    public string? Submenu1 { get; set; }

    public string Subsub { get; set; } = null!;
}

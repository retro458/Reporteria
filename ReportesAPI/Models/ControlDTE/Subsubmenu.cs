using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Subsubmenu
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public string? Menuprincipal { get; set; }

    public string? Submenu { get; set; }

    public string? Menu { get; set; }
}

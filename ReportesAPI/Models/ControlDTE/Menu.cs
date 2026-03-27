using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Menu
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public string? Descripcion { get; set; }

    public string? Submenuuon { get; set; }

    public string? Submenudos { get; set; }

    public string? Submenutres { get; set; }
}

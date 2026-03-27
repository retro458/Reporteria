using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class ProductosUbicacione
{
    public int IdUbicacionproducto { get; set; }

    public int IdUbicacion { get; set; }

    public string Codigodeproducto { get; set; } = null!;

    public string? Creado { get; set; }

    public string? Usuario { get; set; }
}

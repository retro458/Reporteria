using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Categoria
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? Usuario { get; set; }

    public decimal? Comisionuno { get; set; }

    public decimal? Comisiondos { get; set; }
}

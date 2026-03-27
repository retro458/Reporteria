using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class OrdenesDetalle
{
    public int Id { get; set; }

    public string? Usuario { get; set; }

    public DateTime? Fechadecreacion { get; set; }

    public int? Idorden { get; set; }

    public string? Codigodeproducto { get; set; }

    public string? Producto { get; set; }

    public decimal? Cantidad { get; set; }
}

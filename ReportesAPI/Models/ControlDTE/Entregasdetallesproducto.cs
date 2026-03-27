using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Entregasdetallesproducto
{
    public int Id { get; set; }

    public int? Correlativo { get; set; }

    public string? Codigodeproducto { get; set; }

    public string? Descripcion { get; set; }

    public decimal? Cantidad { get; set; }

    public string? Unidaddemedida { get; set; }

    public string? Proveedor { get; set; }

    public DateTime? Creado { get; set; }

    public string? Usuario { get; set; }

    public string? Factura { get; set; }

    public string? Documento { get; set; }

    public bool? Revisado { get; set; }
}

using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class AbonosProveedoresDetalle
{
    public int Id { get; set; }

    public int? Numero { get; set; }

    public string? NoFactura { get; set; }

    public DateOnly? FechaDocumento { get; set; }

    public string? Descripcion { get; set; }

    public string? CuentaContable { get; set; }

    public decimal? Monto { get; set; }

    public string? Nkey { get; set; }

    public string? Usuario { get; set; }

    public DateTime? Creado { get; set; }

    public string? Keydocumento { get; set; }

    public decimal? Descuento { get; set; }

    public decimal? Valorfactura { get; set; }
}

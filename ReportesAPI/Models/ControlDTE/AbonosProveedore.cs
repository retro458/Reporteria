using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class AbonosProveedore
{
    public int Id { get; set; }

    public string? Numero { get; set; }

    public string? CodigoProveedor { get; set; }

    public string? Proveedor { get; set; }

    public string? NoRegistro { get; set; }

    public string? Correlativo { get; set; }

    public string? Documento { get; set; }

    public string? CuentaBanco { get; set; }

    public string? Banco { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? CuentaContable { get; set; }

    public string? Nkey { get; set; }

    public string? Usuario { get; set; }

    public DateTime? Creado { get; set; }

    public string? Bancoempresa { get; set; }

    public string? Cuentabancoempresa { get; set; }

    public string? Cuentacxp { get; set; }

    public decimal? Total { get; set; }

    public string? Referencia { get; set; }

    public DateOnly? Fechadeaplicacion { get; set; }

    public string? Nit { get; set; }

    public string? Tipodecuenta { get; set; }

    public bool? Anulado { get; set; }

    public bool? Eliminado { get; set; }
}

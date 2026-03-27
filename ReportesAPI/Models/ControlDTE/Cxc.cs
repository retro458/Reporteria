using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Cxc
{
    public int Id { get; set; }

    public DateTime? Fechadecreacion { get; set; }

    public string? Idperiodo { get; set; }

    public string? Iddocumento { get; set; }

    public string? Usuario { get; set; }

    public int? Idasociado { get; set; }

    public string? Nombre { get; set; }

    public string? Anombrede { get; set; }

    public DateOnly? Fecha { get; set; }

    public DateTime? Fechadevencimiento { get; set; }

    public decimal? Valor { get; set; }

    public decimal? Saldo { get; set; }

    public bool? Cancelada { get; set; }

    public DateOnly? Fechadecancelacion { get; set; }

    public string? Documento { get; set; }

    public string? Correlativo { get; set; }

    public string? Direccion { get; set; }

    public decimal? Abono { get; set; }
}

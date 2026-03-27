using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Abono
{
    public int IdAbono { get; set; }

    public DateTime? Creado { get; set; }

    public string? Usuario { get; set; }

    public int Correlativo { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? Cliente { get; set; }

    public string? Codigodecliente { get; set; }

    public string? Banco { get; set; }

    public string? FormaDePago { get; set; }

    public decimal? Valor { get; set; }

    public string? Cuentabanco { get; set; }

    public string? Referencia { get; set; }

    public string? Documento { get; set; }

    public string? CorrelativoDocumento { get; set; }

    public bool? Anulado { get; set; }

    public bool? Eliminado { get; set; }
}

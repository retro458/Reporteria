using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class AbonosCliente
{
    public int Id { get; set; }

    public int? Iddos { get; set; }

    public DateOnly? Fecha { get; set; }

    public DateOnly? Fechadocumento { get; set; }

    public string? Documento { get; set; }

    public string? Correlativo { get; set; }

    public string? Codigocliente { get; set; }

    public string? Cliente { get; set; }

    public decimal? Valor { get; set; }

    public string? Tipoabono { get; set; }

    public string? Referencia { get; set; }

    public string? Banco { get; set; }

    public string? Usuario { get; set; }

    public string? Cobradopor { get; set; }

    public string? Keydocumento { get; set; }

    public DateOnly? Creado { get; set; }

    public DateTime? Creadodos { get; set; }

    public DateOnly? Fechacancelacion { get; set; }

    public string? Remesanumero { get; set; }

    public decimal? Transferencia { get; set; }

    public decimal? Cheque { get; set; }

    public decimal? Efectivo { get; set; }

    public string? Tipo { get; set; }

    public string? Modulo { get; set; }
}

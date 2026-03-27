using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Entregasdetallescobro
{
    public int Id { get; set; }

    public int? Correlativo { get; set; }

    public string? Documento { get; set; }

    public string Keydocumento { get; set; } = null!;

    public string? Numero { get; set; }

    public string? Cliente { get; set; }

    public decimal? Total { get; set; }

    public string? Observaciones { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? FormaDePago { get; set; }

    public DateTime? Creado { get; set; }

    public string? Usuario { get; set; }

    public bool? Cancelada { get; set; }

    public string? Tipoabono { get; set; }

    public DateOnly? Fechadecancelacion { get; set; }

    public string? Banco { get; set; }

    public string? Modificadopor { get; set; }

    public DateTime? Fechademodificacion { get; set; }
}

using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Contingencia
{
    public int ContingenciasId { get; set; }

    public string? Codigo { get; set; }

    public DateTime? Fechainicio { get; set; }

    public string? Horainicio { get; set; }

    public DateTime? Fechafin { get; set; }

    public string? Horafin { get; set; }

    public decimal? Tipo { get; set; }

    public string? Motivo { get; set; }

    public bool? Activa { get; set; }
}

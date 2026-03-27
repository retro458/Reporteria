using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Eventosdecontingencium
{
    public int EventosdecontingenciaId { get; set; }

    public string? Codigo { get; set; }

    public decimal? Version { get; set; }

    public string? Ambiente { get; set; }

    public string? Codigogeneracion { get; set; }

    public string? Ftransmision { get; set; }

    public string? Htransmision { get; set; }

    public string? Nit { get; set; }

    public string? Nombre { get; set; }

    public string? Nombreresponsable { get; set; }

    public string? Tipodocresponsable { get; set; }

    public string? Numerodocresponsable { get; set; }

    public string? Codestablemh { get; set; }

    public string? Codpuntoventa { get; set; }

    public string? Telefono { get; set; }

    public string? Correo { get; set; }

    public string? Json { get; set; }

    public string? Jsonfirmado { get; set; }

    public string? Respuesta { get; set; }

    public string? Jsonenviado { get; set; }

    public bool? Procesado { get; set; }
}

using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Grado
{
    public int Id { get; set; }

    public string? IdGrado { get; set; }

    public string? NombreGrado { get; set; }

    public decimal? Matricula { get; set; }

    public decimal? Mensualidad { get; set; }

    public decimal? Moraporcentaje { get; set; }

    public string? Codigo { get; set; }

    public int? IdNivel { get; set; }
}

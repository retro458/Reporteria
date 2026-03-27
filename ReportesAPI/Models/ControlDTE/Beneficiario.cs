using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Beneficiario
{
    public int Id { get; set; }

    public int? Idasociado { get; set; }

    public DateTime? Fechadecreacion { get; set; }

    public string? Codigo { get; set; }

    public string? Usuario { get; set; }

    public string? Nombre { get; set; }

    public DateOnly? Fechadenacimiento { get; set; }

    public string? Lugardenacimiento { get; set; }

    public decimal? Edad { get; set; }

    public string? Parentesco { get; set; }

    public bool? Activo { get; set; }

    public DateOnly? Fechadeinscripcion { get; set; }

    public DateOnly? Fechadebaja { get; set; }
}

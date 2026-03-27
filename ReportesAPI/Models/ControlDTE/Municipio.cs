using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Municipio
{
    public string MunicipioId { get; set; } = null!;

    public string Municipio1 { get; set; } = null!;

    public string DepartamentoId { get; set; } = null!;

    public virtual Departamento Departamento { get; set; } = null!;
}

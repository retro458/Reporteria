using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Departamento
{
    public string DepartamentoId { get; set; } = null!;

    public string Departamento1 { get; set; } = null!;

    public virtual ICollection<Municipio> Municipios { get; set; } = new List<Municipio>();
}

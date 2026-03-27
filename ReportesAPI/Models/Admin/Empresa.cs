using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.Admin;

public partial class Empresa
{
    public int EmpresaId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Subdominio { get; set; } = null!;

    public string DbName { get; set; } = null!;

    public bool? Activa { get; set; }

    public DateTime? CreadoEn { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}

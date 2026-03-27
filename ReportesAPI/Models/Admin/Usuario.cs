using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.Admin;

public partial class Usuario
{
    public int UsuarioId { get; set; }

    public int? EmpresaId { get; set; }

    public string Username { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string? Rol { get; set; }

    public bool? Activo { get; set; }

    public DateTime? CreadoEn { get; set; }

    public virtual Empresa? Empresa { get; set; }
}

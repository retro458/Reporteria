using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class AppUser
{
    public int IdUser { get; set; }

    public DateTime? FechaCreado { get; set; }

    public string? UsuarioCreado { get; set; }

    public string UserName { get; set; } = null!;

    public int? UserLavel { get; set; }

    public byte[] UserPass { get; set; } = null!;

    public byte[] Confirmacion { get; set; } = null!;

    public string? UserRopts { get; set; }

    public string? UserFave { get; set; }

    public string? UserMacro { get; set; }

    public string? UserNotes { get; set; }

    public string Codigo { get; set; } = null!;

    public string? Nombre { get; set; }

    public string Grupo { get; set; } = null!;

    public string CodigodeAlmacen { get; set; } = null!;

    public string Almacen { get; set; } = null!;

    public string? Caja { get; set; }

    public bool? ImprimirReportes { get; set; }

    public byte[]? SueperContraseña { get; set; }

    public string? Dui { get; set; }

    public string? UserLevel { get; set; }

    public bool? Eliminado { get; set; }

    public string? Cargo { get; set; }

    public string? Imagen { get; set; }

    public string? Pc { get; set; }

    public string? CodInstitucion { get; set; }

    public string? Institucion { get; set; }

    public string? Username2 { get; set; }
}

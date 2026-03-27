using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Bitacora
{
    public int Id { get; set; }

    public DateTime? Creado { get; set; }

    public string? Usuario { get; set; }

    public string? Modulo { get; set; }

    public string? Opcionprincipal { get; set; }

    public string? Opcionsecundaria { get; set; }

    public string? Descripcion { get; set; }

    public string? Keydocumento { get; set; }
}

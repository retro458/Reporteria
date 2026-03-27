using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Ubicacione
{
    public int IdUbicacion { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? Usuario { get; set; }

    public DateTime? Creado { get; set; }

    public string? Modificadopor { get; set; }

    public DateTime? Fechamodificacion { get; set; }
}

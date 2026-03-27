using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Mesa
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public string? Descripcion { get; set; }

    public string? Codigodesalon { get; set; }

    public bool? Abierta { get; set; }

    public string? Boton { get; set; }
}

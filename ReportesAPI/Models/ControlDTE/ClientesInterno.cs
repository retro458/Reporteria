using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class ClientesInterno
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public string? Nombre { get; set; }

    public string? Telefono { get; set; }
}

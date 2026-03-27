using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Banco
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string CodigoTransferencia { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class GestiondeCobro
{
    public int IdGestion { get; set; }

    public DateTime FechaCreado { get; set; }

    public string Usuario { get; set; } = null!;

    public DateOnly Fecha { get; set; }

    public string CodigoCliente { get; set; } = null!;

    public string Cliente { get; set; } = null!;

    public decimal Abono { get; set; }

    public decimal Saldo { get; set; }

    public string Nota { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Formasdepago
{
    public int FormasdepagoId { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public decimal Descuento { get; set; }
}

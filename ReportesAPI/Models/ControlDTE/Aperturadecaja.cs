using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Aperturadecaja
{
    public int IdAperturadecaja { get; set; }

    public DateOnly FechadeApertura { get; set; }

    public decimal SaldoInicial { get; set; }

    public bool Cerrada { get; set; }
}

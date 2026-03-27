using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Quedandetalle
{
    public int Id { get; set; }

    public string? Codigokey { get; set; }

    public string? Numero { get; set; }

    public string? Factura { get; set; }

    public DateOnly? Fecha { get; set; }

    public decimal? Valor { get; set; }

    public string? Cuenta { get; set; }

    public string? Descripcion { get; set; }
}

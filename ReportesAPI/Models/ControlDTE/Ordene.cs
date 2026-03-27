using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Ordene
{
    public int Id { get; set; }

    public DateTime? Fechadecreacion { get; set; }

    public string? Usuario { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? Numero { get; set; }

    public string? Solicitadapor { get; set; }

    public decimal? Cantidadsegunformula { get; set; }
}

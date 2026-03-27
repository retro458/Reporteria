using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Fisico
{
    public int IdFisico { get; set; }

    public string? Descripcion { get; set; }

    public decimal? Cantidad { get; set; }

    public DateOnly? Fechavencimiento { get; set; }

    public string? Lote { get; set; }

    public string? Codigodebarra { get; set; }

    public string? Ubicacion { get; set; }

    public string? Codigosistema { get; set; }
}

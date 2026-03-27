using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class CorrelativosDocumento
{
    public int Idcorredocu { get; set; }

    public string Caja { get; set; } = null!;

    public string Codigodealmacen { get; set; } = null!;

    public DateOnly Fechadefacturacion { get; set; }

    public string Codigodedocumento { get; set; } = null!;

    public string Documento { get; set; } = null!;

    public string Ultimocorrelativo { get; set; } = null!;

    public string Resolucionhacienda { get; set; } = null!;

    public string? NumerodeSerie { get; set; }

    public int Numerodelineas { get; set; }

    public DateTime Creado { get; set; }

    public string Usuario { get; set; } = null!;

    public DateOnly? FechadeAutorizacion { get; set; }
}

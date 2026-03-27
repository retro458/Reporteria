using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Cuota
{
    public int CuotaId { get; set; }

    public int? AlumnoId { get; set; }

    public int? CuotaNumero { get; set; }

    public decimal? Cuota1 { get; set; }

    public string? Descripcion { get; set; }

    public DateOnly? Vencimiento { get; set; }

    public DateOnly? Fechadepago { get; set; }

    public string? Referencia { get; set; }

    public string? CodInstitucion { get; set; }

    public int? YearElectivo { get; set; }

    public bool? Cancelada { get; set; }

    public string? Mes { get; set; }

    public string? Codigo { get; set; }

    public bool? Seleccionada { get; set; }
}

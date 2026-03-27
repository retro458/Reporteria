using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Periodo
{
    public int IdPeriodo { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public string? UsuarioCreado { get; set; }

    public string? Codigo { get; set; }

    public string? CodigodeEmpresa { get; set; }

    public string? Descripcion { get; set; }

    public string? Mes { get; set; }

    public string? Año { get; set; }

    public string? Datos { get; set; }

    public string? NumerodeMes { get; set; }

    public string? RaizdeDatos { get; set; }

    public string? KeyId { get; set; }

    public int? Codigop { get; set; }
}

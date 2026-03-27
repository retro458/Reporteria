using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class ParametrosContabilidad
{
    public int IdParametros { get; set; }

    public int IdEmpresa { get; set; }

    public DateTime Fechadecreacion { get; set; }

    public string Tipo { get; set; } = null!;

    public string Clasificacion { get; set; } = null!;

    public decimal Iva { get; set; }

    public decimal PagoaCuenta { get; set; }

    public decimal Renta { get; set; }

    public decimal Percepcion { get; set; }

    public decimal Retencion { get; set; }

    public int Año { get; set; }

    public string Mes { get; set; } = null!;

    public decimal ReservaLegal { get; set; }

    public decimal IsRenta { get; set; }

    public decimal Cotrans { get; set; }

    public string Datos { get; set; } = null!;

    public string UnidadoRecursoCompartido { get; set; } = null!;

    public bool TasaCero { get; set; }

    public decimal NivelUno { get; set; }

    public decimal NivelDos { get; set; }

    public decimal Niveltres { get; set; }

    public decimal NivelCuatro { get; set; }

    public decimal NivelCinco { get; set; }

    public decimal NivelSeis { get; set; }

    public decimal NivelSiete { get; set; }
}

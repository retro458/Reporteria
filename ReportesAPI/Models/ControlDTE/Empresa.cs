using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Empresa
{
    public int IdEmpresa { get; set; }

    public DateTime Fechadecreacion { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string NombreComercial { get; set; } = null!;

    public string? Direccion { get; set; }

    public string? Ciudad { get; set; }

    public string? Departamento { get; set; }

    public string? Telefono { get; set; }

    public string? Telefono2 { get; set; }

    public string? Email { get; set; }

    public string? Notas { get; set; }

    public string? Nrc { get; set; }

    public string? Dui { get; set; }

    public string? Nit { get; set; }

    public string? Giro { get; set; }

    public string? Categoria { get; set; }

    public string? RepresentanteLegal { get; set; }

    public decimal? Iva { get; set; }

    public string? Datos { get; set; }

    public string? Linkfirma { get; set; }

    public string? Linkautenticacion { get; set; }

    public string? Linkrecepcion { get; set; }

    public string? Linkfirmaproductivo { get; set; }

    public string? Linkautenticacionproductivo { get; set; }

    public string? Linkrecepcionproductivo { get; set; }

    public string? Codactividad { get; set; }

    public string? Descactividad { get; set; }

    public string? Coddepartamento { get; set; }

    public string? Codmunicipio { get; set; }

    public string Claveprivada { get; set; } = null!;

    public string Clavepublica { get; set; } = null!;

    public string Claveapi { get; set; } = null!;

    public string? Logo { get; set; }

    public string? Encargadodefacturacion { get; set; }

    public string? Ambiente { get; set; }

    public string? Nombredos { get; set; }
}

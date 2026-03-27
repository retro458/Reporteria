using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Sucursalescliente
{
    public int Id { get; set; }

    public string? Codigodesucursal { get; set; }

    public string? Codigodecliente { get; set; }

    public string? Sucursal { get; set; }

    public string? Nombre { get; set; }

    public string? Direccion { get; set; }

    public string? Zona { get; set; }

    public string? Usuario { get; set; }

    public DateTime? Fechadecreacion { get; set; }

    public string? Telefono { get; set; }

    public string? Ciudad { get; set; }

    public string? Departamento { get; set; }

    public string? Geolocalizacion { get; set; }
}

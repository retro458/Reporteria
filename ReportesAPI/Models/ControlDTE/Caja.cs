using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Caja
{
    public int Cajasid { get; set; }

    public string Caja1 { get; set; } = null!;

    public int? Almacenid { get; set; }

    public string? CodInstitucion { get; set; }

    public string? Institucion { get; set; }

    public string? Resolucionnumero { get; set; }

    public string? Autorizacionnumero { get; set; }

    public DateOnly? Fechadeautorizacion { get; set; }

    public string? Seriedel { get; set; }

    public string? Serieal { get; set; }

    public int? Ultimocortex { get; set; }

    public int? Ultimocortez { get; set; }

    public int? Ultimocortezmensual { get; set; }

    public string? Pc { get; set; }

    public string? Direccion { get; set; }

    public string? Municipio { get; set; }

    public string? Departamento { get; set; }

    public string? Email { get; set; }

    public string? PasswordEmail { get; set; }

    public string? EncargadodeFacturacion { get; set; }

    public string? Telefono1 { get; set; }

    public string? Telefono2 { get; set; }

    public string? Contacto { get; set; }

    public string? Telefonocontacto { get; set; }

    public string? Notas { get; set; }

    public bool? SistemaInstalado { get; set; }

    public DateOnly? FechadeInstalacionn { get; set; }

    public DateOnly? UltimaActualizacion { get; set; }

    public string? Tipo { get; set; }

    public string? Pc2 { get; set; }

    public string? Documentoencargado { get; set; }

    public string? CodEstablecimientoMh { get; set; }

    public string? CodPuntoVentaMh { get; set; }

    public int? Documentosprocesados { get; set; }
}

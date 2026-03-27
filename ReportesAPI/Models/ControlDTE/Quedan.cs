using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Quedan
{
    public int Id { get; set; }

    public string? Codigokey { get; set; }

    public string? Numero { get; set; }

    public DateOnly? Fecha { get; set; }

    public decimal? Valor { get; set; }

    public string? Cuenta { get; set; }

    public string? Descripcion { get; set; }

    public string? Cuentadebanco { get; set; }

    public string? Lugaryfecha { get; set; }

    public decimal? De { get; set; }

    public string? Letras { get; set; }

    public decimal? Total { get; set; }

    public DateTime? Diayhoradepago { get; set; }

    public string? Horade { get; set; }

    public string? Horaa { get; set; }

    public string? Quedan1 { get; set; }

    public string? Almacen { get; set; }

    public string? Codigodealmacen { get; set; }

    public DateOnly? Fechadepago { get; set; }

    public DateOnly? Fechadecancelacion { get; set; }

    public bool? Cancelado { get; set; }

    public string? Notas { get; set; }

    public string? Codigodeproveedor { get; set; }

    public string? Nrc { get; set; }

    public string? Nit { get; set; }

    public decimal? Cuota { get; set; }

    public decimal? Numerodecuotas { get; set; }

    public string? Documentono { get; set; }

    public DateOnly? Fechadocumento { get; set; }
}

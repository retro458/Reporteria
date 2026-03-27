using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Movimientosa
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public string? Numero { get; set; }

    public string? Correlativo { get; set; }

    public string? Codigodedocumento { get; set; }

    public string? Documento { get; set; }

    public DateOnly? Fecha { get; set; }

    public DateTime? Fechadecreacion { get; set; }

    public string? De { get; set; }

    public string? Codigodealmacende { get; set; }

    public string? Para { get; set; }

    public string? Codigodealmacenpara { get; set; }

    public string? Comentarios { get; set; }

    public string? Referencia { get; set; }

    public string? Usuario { get; set; }

    public string? Expediente { get; set; }

    public string? Paciente { get; set; }

    public string? Serie { get; set; }

    public decimal? Total { get; set; }

    public string? Anuladopor { get; set; }

    public DateTime? Fechadeanulacion { get; set; }

    public bool? Eliminado { get; set; }

    public string? Eliminadopor { get; set; }

    public DateTime? Fechadeeliminacion { get; set; }

    public bool? Actualizada { get; set; }

    public bool? Autorizada { get; set; }

    public decimal? TotalCantidad { get; set; }
}

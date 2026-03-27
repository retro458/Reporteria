using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Entregasdetallesnet
{
    public int IdEntregaDet { get; set; }

    public int? Id { get; set; }

    public int? Correlativo { get; set; }

    public string? Documento { get; set; }

    public string? Numero { get; set; }

    public decimal? Total { get; set; }

    public string? Cliente { get; set; }

    public string? Observaciones { get; set; }

    public string? Zona { get; set; }

    public string? Sucursal { get; set; }

    public string? Keydocumento { get; set; }

    public string? Direccion { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? FormaDePago { get; set; }

    public DateTime? Creado { get; set; }

    public string? Usuario { get; set; }

    public bool? Cancelada { get; set; }

    public string? Tipoabono { get; set; }

    public DateOnly? Fechadecancelacion { get; set; }

    public bool? Remesaaplicada { get; set; }

    public string? Banco { get; set; }

    public string? Modificadopor { get; set; }

    public DateTime? Fechademodificaion { get; set; }

    public string? Condiciondepago { get; set; }

    public string? Resolucion { get; set; }

    public int? IdEntrega { get; set; }

    public virtual Entregasnet? IdEntregaNavigation { get; set; }
}

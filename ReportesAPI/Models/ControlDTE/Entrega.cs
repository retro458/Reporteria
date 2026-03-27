using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Entrega
{
    public int Id { get; set; }

    public int? Correlativo { get; set; }

    public DateOnly? Fecha { get; set; }

    public DateTime? Fchadecreacion { get; set; }

    public string? Motorista { get; set; }

    public decimal? Total { get; set; }

    public string? Usuario { get; set; }

    public string? Zona { get; set; }

    public decimal? Totalcobros { get; set; }

    public decimal? Cheques { get; set; }

    public decimal? Efectivo { get; set; }

    public decimal? Transferencias { get; set; }

    public bool? Cerrada { get; set; }

    public bool? Despachada { get; set; }

    public DateTime? Despachadafecha { get; set; }

    public int? IdEntrega { get; set; }

    public virtual ICollection<Entregasdetalle> Entregasdetalles { get; set; } = new List<Entregasdetalle>();
}

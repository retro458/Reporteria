using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Cortex
{
    public int IdCortex { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public string? CodigodeAlmacen { get; set; }

    public string? Caja { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? Numero { get; set; }

    public decimal? VentasConTicket { get; set; }

    public decimal? Ventasconccf { get; set; }

    public string? TicketDesde { get; set; }

    public string? TicketHasta { get; set; }

    public decimal? TotalDevoluciones { get; set; }

    public decimal? TotalVentaNeta { get; set; }

    public decimal? Totaliva { get; set; }

    public decimal? TotalVentasGravadas { get; set; }

    public string? UltimoTicketAnterior { get; set; }

    public string? UltimoTicket { get; set; }

    public decimal? TotalVentas { get; set; }

    public decimal? TotaldeTicket { get; set; }

    public decimal? TotaldeTicketGravados { get; set; }

    public decimal? TotaldeTicketExentos { get; set; }

    public string? Ultimoccf { get; set; }

    public decimal? TotalGabeta { get; set; }

    public string? Usuario { get; set; }

    public DateOnly? FechadeCreacion { get; set; }

    public string? TicketdDesde { get; set; }

    public string? TicketdHasta { get; set; }

    public string? FacturaDesde { get; set; }

    public string? FacturaHasta { get; set; }

    public decimal? VentasconFactura { get; set; }

    public decimal? Tarjeta { get; set; }

    public decimal? BitCoin { get; set; }

    public decimal? Transferencia { get; set; }

    public string? Ccfdesde { get; set; }

    public string? Ccfhasta { get; set; }
}

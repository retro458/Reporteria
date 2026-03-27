using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class ProductosSeleccionado
{
    public int SeleccionadoId { get; set; }

    public DateTime? Creado { get; set; }

    public string? Usuario { get; set; }

    public int LoteId { get; set; }

    public decimal? CantidadSeleccionada { get; set; }

    public decimal? ExistenciaLote { get; set; }

    public decimal? SeleccionadoLote { get; set; }

    public string? KeyVenta { get; set; }
}

using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class InventarioDetalle
{
    public int Id { get; set; }

    public int? Inventario { get; set; }

    public string? Usuario { get; set; }

    public DateTime? FechadeCreacion { get; set; }

    public string? CodigoProducto { get; set; }

    public string? Descripcion { get; set; }

    public decimal? ExistenciaFisica { get; set; }

    public decimal? ExistenciaSistema { get; set; }

    public decimal? Diferencia { get; set; }

    public string? Categoria { get; set; }

    public DateOnly? Fechavencimientolote { get; set; }

    public string? Ubicacion { get; set; }

    public string? Lote { get; set; }

    public string? Unidaddemedida { get; set; }

    public bool? Perecedero { get; set; }

    public string? Observacion { get; set; }

    public string? Proveedor { get; set; }

    public string? Codigonuevo { get; set; }

    public string? Noestaenproductos { get; set; }
}

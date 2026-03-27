using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Producto
{
    public int ProductoId { get; set; }

    public DateTime? Fechadecreacion { get; set; }

    public string? Usuario { get; set; }

    public string? Codigo { get; set; }

    public string? Descripcion { get; set; }

    public decimal? Existencia { get; set; }

    public decimal? ExistenciaAnterior { get; set; }

    public decimal? Costo { get; set; }

    public string? Unidaddemedida { get; set; }

    public string? Categoria { get; set; }

    public string? Proveedor { get; set; }

    public decimal? Preciouno { get; set; }

    public decimal? Preciodos { get; set; }

    public decimal? Preciotres { get; set; }

    public decimal? Stockminimo { get; set; }

    public decimal? Stockmaximo { get; set; }

    public byte? Exento { get; set; }

    public string? Marca { get; set; }

    public string? Modelo { get; set; }

    public bool? Suspendido { get; set; }

    public bool? Servicio { get; set; }

    public string? Ubicacion { get; set; }

    public string? Subcategoria { get; set; }

    public decimal? Existenciainicial { get; set; }

    public decimal? Costoinicial { get; set; }

    public DateOnly? Fechainicial { get; set; }

    public decimal? Existenciainiciados { get; set; }

    public decimal? Existenciainiciatres { get; set; }

    public decimal? Existenciainiciacuatro { get; set; }

    public string? Proveedorsecundario { get; set; }

    public decimal? Utilidaduno { get; set; }

    public decimal? Utilidaddos { get; set; }

    public decimal? Utilidadtres { get; set; }

    public decimal? Ultimocosto { get; set; }

    public decimal? Costoconimpuesto { get; set; }

    public decimal? CostoPromedio { get; set; }

    public string? Oem { get; set; }

    public decimal? Existenciados { get; set; }

    public decimal? Existenciatres { get; set; }

    public decimal? Existenciageneral { get; set; }

    public decimal? Costofob { get; set; }

    public decimal? Fisicosucuno { get; set; }

    public decimal? Fisicosucdos { get; set; }

    public decimal? Fisicosuctres { get; set; }

    public decimal? Existenciainicia { get; set; }

    public string? Eiminadopor { get; set; }

    public DateTime? Fechadeeliminacion { get; set; }

    public string? Imagen1 { get; set; }

    public string? Imagen2 { get; set; }

    public string? Imagen3 { get; set; }

    public string? Imagen4 { get; set; }

    public bool? Eliminado { get; set; }

    public string? Notas { get; set; }

    public string? Codigodebarras { get; set; }

    public bool? Noaplicadescuento { get; set; }

    public string? Descripciondos { get; set; }

    public string? CodInstitucion { get; set; }

    public string? Cuenta { get; set; }
}

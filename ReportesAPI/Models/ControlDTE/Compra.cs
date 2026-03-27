using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Compra
{
    public int Id { get; set; }

    public string? Numero { get; set; }

    public string? Correlativo { get; set; }

    public string? Documento { get; set; }

    public string? DocumentoCodigo { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? Proveedorcodigo { get; set; }

    public string? Proveedor { get; set; }

    public string? Direccion { get; set; }

    public string? Ciudad { get; set; }

    public string? Departamento { get; set; }

    public string? NoRegistro { get; set; }

    public string? Giro { get; set; }

    public string? FormaDePago { get; set; }

    public bool? Cancelada { get; set; }

    public bool? DocumentoActivo { get; set; }

    public bool? Excenta { get; set; }

    public decimal? Sumas { get; set; }

    public decimal? Descuento { get; set; }

    public decimal? Iva { get; set; }

    public decimal? VentaTotal { get; set; }

    public string? Comentario { get; set; }

    public string? Codalmacen { get; set; }

    public string? Almacen { get; set; }

    public bool? Siniva { get; set; }

    public bool? Vincular { get; set; }

    public bool? Noactualizados { get; set; }

    public bool? Calculos { get; set; }

    public decimal? Diasdecredito { get; set; }

    public DateOnly? Fechadevencimiento { get; set; }

    public decimal? Saldo { get; set; }

    public string? Cuenta { get; set; }

    public string? Usuario { get; set; }

    public decimal? Ivapercibido { get; set; }

    public bool? Aplicarpercepcion { get; set; }

    public DateOnly? Fechadedeclaracion { get; set; }

    public decimal? Comprasexentasinternas { get; set; }

    public decimal? Comprasexentasimportaciones { get; set; }

    public decimal? Gravadasinternas { get; set; }

    public decimal? Gravadasimportaciones { get; set; }

    public decimal? Comprasaexcluidos { get; set; }

    public decimal? Comprasgravadas { get; set; }

    public decimal? Comprasexentas { get; set; }

    public bool? Anulada { get; set; }

    public string? Nit { get; set; }

    public string? Dui { get; set; }

    public string? Referenciacheque { get; set; }

    public decimal? Fovial { get; set; }

    public decimal? Comprasgravadasimportaciones { get; set; }

    public decimal? Comprasgravadasinternas { get; set; }

    public string? Descripcion { get; set; }

    public string? Centacontable { get; set; }

    public decimal? Valorneto { get; set; }

    public string? Tipo { get; set; }

    public string? Concepto { get; set; }

    public decimal? Dia { get; set; }

    public decimal? Retencion { get; set; }

    public bool? Aplicarretencion { get; set; }

    public decimal? Cotrans { get; set; }

    public decimal? Sumacostofob { get; set; }

    public string? Categoria { get; set; }

    public string? Condiciondepago { get; set; }

    public decimal? Saldodelafactura { get; set; }

    public decimal? Saldo30 { get; set; }

    public decimal? Saldo60 { get; set; }

    public decimal? Saldo90 { get; set; }

    public decimal? Saldo90ymas { get; set; }

    public decimal? Despacho { get; set; }

    public decimal? Flete { get; set; }

    public decimal? Seguro { get; set; }

    public decimal? Otros { get; set; }

    public decimal? Totalgastosexterior { get; set; }

    public string? Telyfax { get; set; }

    public decimal? Extraordinarios { get; set; }

    public decimal? Cepa { get; set; }

    public decimal? Agenteaduanal { get; set; }

    public decimal? Fleteypasaje { get; set; }

    public decimal? Otrosgl { get; set; }

    public decimal? Totalgl { get; set; }

    public decimal? Tasadecambio { get; set; }

    public decimal? Factorutilidad { get; set; }

    public decimal? Pesobruto { get; set; }

    public decimal? Bultos { get; set; }

    public string? Transportista { get; set; }

    public string? Guiaaerea { get; set; }

    public string? Nopoliza { get; set; }

    public decimal? Gastopoliza { get; set; }

    public string? Duionit { get; set; }

    public string? Referencia { get; set; }

    public decimal? Total { get; set; }

    public DateOnly? Fechadecancelacion { get; set; }

    public string? Placa { get; set; }

    public string? Orden { get; set; }

    public string? Descripcionvehiculo { get; set; }

    public decimal? Valordescuento { get; set; }

    public decimal? Totalsumas { get; set; }

    public string? Quedan { get; set; }

    public string? Cheque { get; set; }

    public decimal? Valordecredito { get; set; }

    public string? Codigodoc { get; set; }

    public DateTime? Fechadecreacion { get; set; }

    public decimal? Comprobantedeliquidacion { get; set; }

    public decimal? Percepcion { get; set; }

    public string? Salidaddeefectivo { get; set; }

    public string? Proyecto { get; set; }

    public decimal? Credito { get; set; }

    public bool? Eliminado { get; set; }

    public string? Eliminadopor { get; set; }

    public DateOnly? FechadeEliminacion { get; set; }

    public bool? Seleccionada { get; set; }

    public decimal? Diasdevencido { get; set; }

    public string? Serienumero { get; set; }

    public string? Numeroderesolucion { get; set; }

    public string? Sectorrenta { get; set; }

    public string? Tipocostogasto { get; set; }

    public string? Tipodeoperacion { get; set; }
}

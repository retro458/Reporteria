using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Salida
{
    public int VentaId { get; set; }

    public string? Codigo { get; set; }

    public string? Correlativo { get; set; }

    public string? Documentocodigo { get; set; }

    public string? Documento { get; set; }

    public string? Almacencodigo { get; set; }

    public string? Sucursal { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? Clientecodigo { get; set; }

    public string? Cliente { get; set; }

    public string? Direccion { get; set; }

    public string? Ciudad { get; set; }

    public string? Departamento { get; set; }

    public string? NoRegistro { get; set; }

    public string? Giro { get; set; }

    public string? Telefono { get; set; }

    public string? Telefono2 { get; set; }

    public string? FormaDePago { get; set; }

    public bool? Cancelada { get; set; }

    public bool? Documentoactivo { get; set; }

    public decimal? ValorNeto { get; set; }

    public decimal? Iva { get; set; }

    public decimal? Valorretencion { get; set; }

    public decimal? VentaTotal { get; set; }

    public string? Comentario { get; set; }

    public bool? Actualizada { get; set; }

    public DateOnly? FechaReferencia { get; set; }

    public string? Referencia { get; set; }

    public decimal? Saldo { get; set; }

    public string? Chequenumero { get; set; }

    public decimal? Valor { get; set; }

    public decimal? Diasdecredito { get; set; }

    public DateOnly? Fechadevencimiento { get; set; }

    public decimal? Saldodelafactura { get; set; }

    public string? CodigoVendedor { get; set; }

    public string? Vendedor { get; set; }

    public string? Nit { get; set; }

    public string? Notaderemision { get; set; }

    public string? Usuario { get; set; }

    public decimal? Vcontado { get; set; }

    public decimal? Vcredito { get; set; }

    public decimal? Abono { get; set; }

    public decimal? Subtotal { get; set; }

    public decimal? Exentas { get; set; }

    public decimal? Saldo30 { get; set; }

    public decimal? Saldo60 { get; set; }

    public decimal? Saldo90 { get; set; }

    public decimal? Saldo90ymas { get; set; }

    public bool? Retencion { get; set; }

    public string? Numero { get; set; }

    public decimal? Vetasexentas { get; set; }

    public decimal? Exportaciones { get; set; }

    public decimal? Gravadas { get; set; }

    public decimal? Ivapercibido { get; set; }

    public bool? Aplicarpercepcion { get; set; }

    public decimal? Gravadasconsumidores { get; set; }

    public decimal? Fovial { get; set; }

    public string? Correlativohasta { get; set; }

    public decimal? Exportacionesfuera { get; set; }

    public decimal? Exportacionesregion { get; set; }

    public decimal? Zonasydpa { get; set; }

    public decimal? Total { get; set; }

    public decimal? Ventaexenta { get; set; }

    public decimal? Ivaretenido { get; set; }

    public string? Email { get; set; }

    public string? Caja { get; set; }

    public string? Dui { get; set; }

    public bool? Aplicaretencion { get; set; }

    public decimal? Descuento { get; set; }

    public decimal? Valordeldescuento { get; set; }

    public decimal? Sumas { get; set; }

    public DateOnly? Fechadecancelacion { get; set; }

    public string? Categoria { get; set; }

    public decimal? Ventasiniva { get; set; }

    public string? Concepto { get; set; }

    public string? Clasificasion { get; set; }

    public decimal? Tarjeta { get; set; }

    public string? Categoriadeventa { get; set; }

    public DateTime? Fechadecancelado { get; set; }

    public DateTime? Fechadecreacion { get; set; }

    public string? Autorizadopor { get; set; }

    public decimal? Remesa { get; set; }

    public decimal? Transferencia { get; set; }

    public string? Banco { get; set; }

    public string? Telefonocheque { get; set; }

    public string? Anuladopor { get; set; }

    public DateTime? Fechadeanulacion { get; set; }

    public bool? Eliminado { get; set; }

    public string? Eliminadopor { get; set; }

    public DateTime? Fechadeeliminacion { get; set; }

    public decimal? Gravadasaconsumidores { get; set; }

    public string? Notas { get; set; }

    public string? NumerodeSerie { get; set; }

    public string? NumerodeResolucion { get; set; }

    public DateOnly? FechadeAutorizacion { get; set; }

    public decimal? Efectivo { get; set; }

    public decimal? Cambio { get; set; }

    public bool? Seleccionada { get; set; }

    public int? ClienteId { get; set; }

    public decimal? Bitcoin { get; set; }

    public decimal? Tarjetatv { get; set; }

    public decimal? Tarjetadv { get; set; }

    public decimal? Tarjetauv { get; set; }

    public virtual ICollection<SalidasDetalle> SalidasDetalles { get; set; } = new List<SalidasDetalle>();
}

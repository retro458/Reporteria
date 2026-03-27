using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Venta
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

    public bool? Clienteexento { get; set; }

    public string? Notasdos { get; set; }

    public bool? Sujetodepercepcion { get; set; }

    public string? EstadoComision { get; set; }

    public string? Gestionado { get; set; }

    public string? CodActividad { get; set; }

    public string? CodMunicipio { get; set; }

    public string? CodDepartamento { get; set; }

    public string? Ambiente { get; set; }

    public decimal? Renta { get; set; }

    public string? NombreComercial { get; set; }

    public string? Tipotransmision { get; set; }

    public string? Modelodefacturacion { get; set; }

    public bool? Correoenviado { get; set; }

    public string? Hora { get; set; }

    public string? Documentorecibidopor { get; set; }

    public string? Recibidopor { get; set; }

    public string? Documentoentregado { get; set; }

    public string? Encargadodeentrega { get; set; }

    public string? Selloderecibido { get; set; }

    public string? Jsoncliente { get; set; }

    public DateTime? Fechadeprocesado { get; set; }

    public bool? Procesado { get; set; }

    public string? Jsonenviado { get; set; }

    public string? Numerodecontrol { get; set; }

    public string? CodigoGeneracion { get; set; }

    public string? Respuesta { get; set; }

    public string? Jsonfirmado { get; set; }

    public string? Json { get; set; }

    public string? Token { get; set; }

    public string? Serienumero { get; set; }

    public DateTime? Creado { get; set; }

    public string? Descactividad { get; set; }

    public DateTime? Fechaprocesado { get; set; }

    public string Documentoencargado { get; set; } = null!;

    public int? Modocontingencia { get; set; }

    public string? Condiciondepago { get; set; }

    public string? Pais { get; set; }

    public string? Codpais { get; set; }

    public string? Recinto { get; set; }

    public string? Regimen { get; set; }

    public bool? Aplicarenta { get; set; }

    public string? Clasificacion { get; set; }

    public decimal? Nosujetas { get; set; }

    public string? Formadepago { get; set; }

    public string? DirInst { get; set; }

    public string? MunInst { get; set; }

    public string? DepInst { get; set; }

    public string? EmaInst { get; set; }

    public string? TelInst { get; set; }

    public bool? Invalidado { get; set; }

    public string Titulo { get; set; } = null!;

    public string? Tipodeoperacion { get; set; }

    public string? Tipodeingreso { get; set; }

    public DateOnly? Fechainvalidacion { get; set; }

    public virtual ICollection<SalidasDetalle> SalidasDetalles { get; set; } = new List<SalidasDetalle>();
}

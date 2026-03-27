using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ReportesAPI.Models.ControlDTE;

namespace ReportesAPI.Data;

public partial class ControlDTEContext : DbContext
{
    public ControlDTEContext(DbContextOptions<ControlDTEContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Abono> Abonos { get; set; }

    public virtual DbSet<AbonosCliente> AbonosClientes { get; set; }

    public virtual DbSet<AbonosProveedore> AbonosProveedores { get; set; }

    public virtual DbSet<AbonosProveedoresDetalle> AbonosProveedoresDetalles { get; set; }

    public virtual DbSet<Abonosclientesbanco> Abonosclientesbancos { get; set; }

    public virtual DbSet<Abonoscxc> Abonoscxcs { get; set; }

    public virtual DbSet<AbonoscxcDetalle> AbonoscxcDetalles { get; set; }

    public virtual DbSet<ActividadesEconomica> ActividadesEconomicas { get; set; }

    public virtual DbSet<Ajuste> Ajustes { get; set; }

    public virtual DbSet<AjustesDetalle> AjustesDetalles { get; set; }

    public virtual DbSet<Almacene> Almacenes { get; set; }

    public virtual DbSet<Alumno> Alumnos { get; set; }

    public virtual DbSet<Aperturadecaja> Aperturadecajas { get; set; }

    public virtual DbSet<AppUser> AppUsers { get; set; }

    public virtual DbSet<Asociado> Asociados { get; set; }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

    public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }

    public virtual DbSet<Banco> Bancos { get; set; }

    public virtual DbSet<Beneficiario> Beneficiarios { get; set; }

    public virtual DbSet<Bitacora> Bitacoras { get; set; }

    public virtual DbSet<Caja> Cajas { get; set; }

    public virtual DbSet<Cajero> Cajeros { get; set; }

    public virtual DbSet<Cargosusuario> Cargosusuarios { get; set; }

    public virtual DbSet<Categoria> Categorias { get; set; }

    public virtual DbSet<ClasificacionTributarium> ClasificacionTributaria { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<ClientesInterno> ClientesInternos { get; set; }

    public virtual DbSet<Compra> Compras { get; set; }

    public virtual DbSet<ComprasDetalle> ComprasDetalles { get; set; }

    public virtual DbSet<Configcuota> Configcuotas { get; set; }

    public virtual DbSet<Contingencia> Contingencias { get; set; }

    public virtual DbSet<Contribuyente> Contribuyentes { get; set; }

    public virtual DbSet<Correlativo> Correlativos { get; set; }

    public virtual DbSet<CorrelativoAjuste> CorrelativoAjustes { get; set; }

    public virtual DbSet<CorrelativosDocumento> CorrelativosDocumentos { get; set; }

    public virtual DbSet<Correlativoso> Correlativosos { get; set; }

    public virtual DbSet<Cortemv> Cortemvs { get; set; }

    public virtual DbSet<Cortex> Cortexes { get; set; }

    public virtual DbSet<Cortez> Cortezs { get; set; }

    public virtual DbSet<Cotizacion> Cotizacions { get; set; }

    public virtual DbSet<CotizacionDetalle> CotizacionDetalles { get; set; }

    public virtual DbSet<Cuenta> Cuentas { get; set; }

    public virtual DbSet<Cuota> Cuotas { get; set; }

    public virtual DbSet<Cxc> Cxcs { get; set; }

    public virtual DbSet<DatosFiscale> DatosFiscales { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<Departamento1> Departamentos1 { get; set; }

    public virtual DbSet<Distribucion> Distribucions { get; set; }

    public virtual DbSet<Documento> Documentos { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<Entrega> Entregas { get; set; }

    public virtual DbSet<Entregasdetalle> Entregasdetalles { get; set; }

    public virtual DbSet<Entregasdetallescobro> Entregasdetallescobros { get; set; }

    public virtual DbSet<Entregasdetallesnet> Entregasdetallesnets { get; set; }

    public virtual DbSet<Entregasdetallesproducto> Entregasdetallesproductos { get; set; }

    public virtual DbSet<Entregasdetallesquedan> Entregasdetallesquedans { get; set; }

    public virtual DbSet<Entregasnet> Entregasnets { get; set; }

    public virtual DbSet<Eventosdecontingencium> Eventosdecontingencia { get; set; }

    public virtual DbSet<Fisico> Fisicos { get; set; }

    public virtual DbSet<Formasdepago> Formasdepagos { get; set; }

    public virtual DbSet<GestiondeCobro> GestiondeCobros { get; set; }

    public virtual DbSet<Grado> Grados { get; set; }

    public virtual DbSet<Invalidacione> Invalidaciones { get; set; }

    public virtual DbSet<Inventario> Inventarios { get; set; }

    public virtual DbSet<InventarioDetalle> InventarioDetalles { get; set; }

    public virtual DbSet<Lote> Lotes { get; set; }

    public virtual DbSet<Maestra> Maestras { get; set; }

    public virtual DbSet<Matricula> Matriculas { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<Mesa> Mesas { get; set; }

    public virtual DbSet<Mesero> Meseros { get; set; }

    public virtual DbSet<Motorista> Motoristas { get; set; }

    public virtual DbSet<Movimientosa> Movimientosas { get; set; }

    public virtual DbSet<MovimientosaDetalle> MovimientosaDetalles { get; set; }

    public virtual DbSet<Municipio> Municipios { get; set; }

    public virtual DbSet<Municipio1> Municipios1 { get; set; }

    public virtual DbSet<Ordene> Ordenes { get; set; }

    public virtual DbSet<OrdenesDetalle> OrdenesDetalles { get; set; }

    public virtual DbSet<Paise> Paises { get; set; }

    public virtual DbSet<ParametrosContabilidad> ParametrosContabilidads { get; set; }

    public virtual DbSet<Periodo> Periodos { get; set; }

    public virtual DbSet<Precio> Precios { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<ProductosSeleccionado> ProductosSeleccionados { get; set; }

    public virtual DbSet<ProductosUbicacione> ProductosUbicaciones { get; set; }

    public virtual DbSet<Proveedore> Proveedores { get; set; }

    public virtual DbSet<Quedan> Quedans { get; set; }

    public virtual DbSet<Quedandetalle> Quedandetalles { get; set; }

    public virtual DbSet<Rechazado> Rechazados { get; set; }

    public virtual DbSet<Reinicio> Reinicios { get; set; }

    public virtual DbSet<Reporte> Reportes { get; set; }

    public virtual DbSet<Salida> Salidas { get; set; }

    public virtual DbSet<SalidasDetalle> SalidasDetalles { get; set; }

    public virtual DbSet<Salone> Salones { get; set; }

    public virtual DbSet<Subcategorium> Subcategoria { get; set; }

    public virtual DbSet<Submenu> Submenus { get; set; }

    public virtual DbSet<Subsubmenu> Subsubmenus { get; set; }

    public virtual DbSet<Sucursalescliente> Sucursalesclientes { get; set; }

    public virtual DbSet<Supervisore> Supervisores { get; set; }

    public virtual DbSet<Titulosbiene> Titulosbienes { get; set; }

    public virtual DbSet<Token> Tokens { get; set; }

    public virtual DbSet<Ubicacione> Ubicaciones { get; set; }

    public virtual DbSet<Unidadesdemedida> Unidadesdemedidas { get; set; }

    public virtual DbSet<Utilidade> Utilidades { get; set; }

    public virtual DbSet<Venta> Ventas { get; set; }

    public virtual DbSet<VentasDetalle> VentasDetalles { get; set; }

    public virtual DbSet<Zona> Zonas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<Abono>(entity =>
        {
            entity.HasKey(e => e.IdAbono);

            entity.Property(e => e.Anulado).HasDefaultValue(false);
            entity.Property(e => e.Banco)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Cliente)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Codigodecliente)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.CorrelativoDocumento)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Creado)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.Cuentabanco)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Documento)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Eliminado).HasDefaultValue(false);
            entity.Property(e => e.FormaDePago)
                .HasMaxLength(18)
                .HasColumnName("Forma_de_pago");
            entity.Property(e => e.Referencia).HasMaxLength(18);
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Valor)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
        });

        modelBuilder.Entity<AbonosCliente>(entity =>
        {
            entity.Property(e => e.Banco)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Cheque).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Cliente)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.Cobradopor)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Codigocliente)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Correlativo)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Creado).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Creadodos)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Efectivo).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Fecha).HasDefaultValueSql("('')");
            entity.Property(e => e.Fechadocumento)
                .HasDefaultValueSql("('')")
                .HasColumnName("fechadocumento");
            entity.Property(e => e.Iddos).HasDefaultValue(0);
            entity.Property(e => e.Keydocumento)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Modulo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Referencia)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Remesanumero)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Tipoabono)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Transferencia).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Valor)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
        });

        modelBuilder.Entity<AbonosProveedore>(entity =>
        {
            entity.Property(e => e.Anulado).HasDefaultValue(false);
            entity.Property(e => e.Banco)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Bancoempresa).HasMaxLength(50);
            entity.Property(e => e.CodigoProveedor)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Correlativo)
                .HasMaxLength(75)
                .HasDefaultValue("");
            entity.Property(e => e.Creado)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.CuentaBanco)
                .HasMaxLength(30)
                .HasDefaultValue("")
                .HasColumnName("Cuenta_banco");
            entity.Property(e => e.CuentaContable)
                .HasMaxLength(18)
                .HasDefaultValue("")
                .HasColumnName("Cuenta_contable");
            entity.Property(e => e.Cuentabancoempresa).HasMaxLength(30);
            entity.Property(e => e.Cuentacxp)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Documento)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Eliminado).HasDefaultValue(false);
            entity.Property(e => e.Nit)
                .HasMaxLength(20)
                .HasDefaultValue("")
                .HasColumnName("NIT");
            entity.Property(e => e.Nkey).HasMaxLength(18);
            entity.Property(e => e.NoRegistro)
                .HasMaxLength(15)
                .HasDefaultValue("")
                .HasColumnName("No_registro");
            entity.Property(e => e.Numero)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Referencia)
                .HasMaxLength(75)
                .HasDefaultValue("");
            entity.Property(e => e.Tipodecuenta)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Total).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Usuario).HasMaxLength(50);
        });

        modelBuilder.Entity<AbonosProveedoresDetalle>(entity =>
        {
            entity.ToTable("AbonosProveedores_detalles");

            entity.Property(e => e.Creado)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.CuentaContable)
                .HasMaxLength(18)
                .HasDefaultValue("")
                .HasColumnName("Cuenta_contable");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Descuento).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.FechaDocumento).HasColumnName("Fecha_documento");
            entity.Property(e => e.Keydocumento)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Monto)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Nkey)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.NoFactura)
                .HasMaxLength(18)
                .HasDefaultValue("")
                .HasColumnName("No_factura");
            entity.Property(e => e.Numero).HasDefaultValue(0);
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Valorfactura)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
        });

        modelBuilder.Entity<Abonosclientesbanco>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Banco)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Cuentacontable)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Referencia)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Valor)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
        });

        modelBuilder.Entity<Abonoscxc>(entity =>
        {
            entity.HasKey(e => e.VentaId);

            entity.ToTable("abonoscxc");

            entity.Property(e => e.Abono).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Almacencodigo).HasMaxLength(18);
            entity.Property(e => e.Anuladopor).HasMaxLength(50);
            entity.Property(e => e.Autorizadopor).HasMaxLength(50);
            entity.Property(e => e.Banco).HasMaxLength(50);
            entity.Property(e => e.Bitcoin).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Caja).HasMaxLength(10);
            entity.Property(e => e.Cambio).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Categoriadeventa).HasMaxLength(50);
            entity.Property(e => e.Chequenumero).HasMaxLength(18);
            entity.Property(e => e.Ciudad).HasMaxLength(30);
            entity.Property(e => e.Clasificasion).HasMaxLength(50);
            entity.Property(e => e.Cliente).HasMaxLength(120);
            entity.Property(e => e.Clientecodigo).HasMaxLength(18);
            entity.Property(e => e.Codigo).HasMaxLength(18);
            entity.Property(e => e.CodigoVendedor).HasMaxLength(18);
            entity.Property(e => e.Comentario).HasMaxLength(250);
            entity.Property(e => e.Concepto).HasMaxLength(90);
            entity.Property(e => e.Correlativo).HasMaxLength(10);
            entity.Property(e => e.Correlativohasta).HasMaxLength(18);
            entity.Property(e => e.Departamento).HasMaxLength(30);
            entity.Property(e => e.Descuento).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Diasdecredito).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Direccion).HasMaxLength(250);
            entity.Property(e => e.Documento).HasMaxLength(60);
            entity.Property(e => e.Documentocodigo).HasMaxLength(30);
            entity.Property(e => e.Dui).HasMaxLength(30);
            entity.Property(e => e.Efectivo).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Eliminadopor).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.EstadoComision)
                .HasMaxLength(9)
                .IsFixedLength();
            entity.Property(e => e.Exentas).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Exportaciones).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Exportacionesfuera).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Exportacionesregion).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Fechadeanulacion).HasColumnType("datetime");
            entity.Property(e => e.Fechadecancelado).HasColumnType("datetime");
            entity.Property(e => e.Fechadecreacion).HasColumnType("datetime");
            entity.Property(e => e.Fechadeeliminacion).HasColumnType("datetime");
            entity.Property(e => e.FormaDePago)
                .HasMaxLength(30)
                .HasColumnName("Forma_de_pago");
            entity.Property(e => e.Fovial).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Gestionado)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Giro).HasMaxLength(250);
            entity.Property(e => e.Gravadas).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Gravadasaconsumidores).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Gravadasconsumidores).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Iva).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Ivapercibido).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Ivaretenido).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Nit).HasMaxLength(25);
            entity.Property(e => e.NoRegistro)
                .HasMaxLength(50)
                .HasColumnName("No_registro");
            entity.Property(e => e.Notaderemision).HasMaxLength(4);
            entity.Property(e => e.Notas).HasMaxLength(250);
            entity.Property(e => e.Notasdos).HasMaxLength(250);
            entity.Property(e => e.Numero).HasMaxLength(18);
            entity.Property(e => e.NumerodeResolucion).HasMaxLength(30);
            entity.Property(e => e.NumerodeSerie).HasMaxLength(30);
            entity.Property(e => e.Referencia).HasMaxLength(18);
            entity.Property(e => e.Remesa).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Saldo).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Saldo30).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Saldo60).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Saldo90).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Saldo90ymas).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Saldodelafactura).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Subtotal).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Sucursal).HasMaxLength(50);
            entity.Property(e => e.Sumas).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Tarjeta).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Tarjetadv).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Tarjetatv).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Tarjetauv).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Telefono).HasMaxLength(25);
            entity.Property(e => e.Telefono2).HasMaxLength(25);
            entity.Property(e => e.Telefonocheque).HasMaxLength(50);
            entity.Property(e => e.Total).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Transferencia).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Usuario).HasMaxLength(40);
            entity.Property(e => e.Valor).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.ValorNeto)
                .HasColumnType("numeric(18, 9)")
                .HasColumnName("Valor_neto");
            entity.Property(e => e.Valordeldescuento).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Valorretencion).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Vcontado).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Vcredito).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Vendedor).HasMaxLength(60);
            entity.Property(e => e.VentaTotal)
                .HasColumnType("numeric(18, 9)")
                .HasColumnName("Venta_total");
            entity.Property(e => e.Ventaexenta).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Ventasiniva).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Vetasexentas).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Zonasydpa).HasColumnType("numeric(18, 9)");
        });

        modelBuilder.Entity<AbonoscxcDetalle>(entity =>
        {
            entity.HasKey(e => e.AvonoscxcDetallesId);

            entity.ToTable("abonoscxc_detalles");

            entity.Property(e => e.AvonoscxcDetallesId).HasColumnName("Avonoscxc_detallesId");
            entity.Property(e => e.Almacenalias).HasMaxLength(40);
            entity.Property(e => e.Almacencodigo).HasMaxLength(18);
            entity.Property(e => e.Barra).HasMaxLength(60);
            entity.Property(e => e.Cantidad).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Categoria).HasMaxLength(90);
            entity.Property(e => e.Codigo).HasMaxLength(20);
            entity.Property(e => e.Comision).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Correlativo).HasMaxLength(10);
            entity.Property(e => e.Costo).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Costodeimportacion).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Descuento).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Documentocodigo).HasMaxLength(18);
            entity.Property(e => e.Facturacion).HasMaxLength(18);
            entity.Property(e => e.Facturaoccf).HasMaxLength(30);
            entity.Property(e => e.Fechadecreacion).HasColumnType("datetime");
            entity.Property(e => e.Fechahoracambioprecio).HasColumnName("fechahoracambioprecio");
            entity.Property(e => e.Item).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Justificacion).HasMaxLength(254);
            entity.Property(e => e.Margen).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Nombre).HasMaxLength(250);
            entity.Property(e => e.Nosujetas).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Notaderemision).HasMaxLength(30);
            entity.Property(e => e.PorcentajeGanancia).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.PrecioConIva)
                .HasColumnType("numeric(18, 9)")
                .HasColumnName("Precio_con_iva");
            entity.Property(e => e.PrecioFacturado).HasMaxLength(75);
            entity.Property(e => e.PrecioUni)
                .HasColumnType("numeric(18, 9)")
                .HasColumnName("Precio_uni");
            entity.Property(e => e.Preciosindescuento).HasColumnType("decimal(18, 9)");
            entity.Property(e => e.Preciosiniva).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Productocodigo).HasMaxLength(75);
            entity.Property(e => e.Proveedor).HasMaxLength(200);
            entity.Property(e => e.Referencia).HasMaxLength(40);
            entity.Property(e => e.Subtotal).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Unidaddemedida).HasMaxLength(30);
            entity.Property(e => e.Usuario).HasMaxLength(50);
            entity.Property(e => e.Usuariocambioprecio).HasMaxLength(50);
            entity.Property(e => e.ValorGanancia).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Valorcomision).HasColumnType("decimal(18, 9)");
            entity.Property(e => e.Ventaexenta).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Ventasafectas).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Ventasexenta).HasColumnType("numeric(18, 9)");
        });

        modelBuilder.Entity<ActividadesEconomica>(entity =>
        {
            entity.HasKey(e => e.ActividadesEconomicasId);

            entity.ToTable("Actividades_Economicas");

            entity.Property(e => e.ActividadesEconomicasId).HasColumnName("Actividades_EconomicasId");
            entity.Property(e => e.Actividad).HasMaxLength(175);
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .IsFixedLength();
        });

        modelBuilder.Entity<Ajuste>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Entradas");

            entity.Property(e => e.Agenteaduanal)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Almacen)
                .HasMaxLength(75)
                .HasDefaultValue("");
            entity.Property(e => e.Anulada).HasDefaultValue(false);
            entity.Property(e => e.Aplicarpercepcion).HasDefaultValue(true);
            entity.Property(e => e.Aplicarretencion).HasDefaultValue(true);
            entity.Property(e => e.Bultos)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Calculos).HasDefaultValue(true);
            entity.Property(e => e.Cancelada).HasDefaultValue(true);
            entity.Property(e => e.Categoria)
                .HasMaxLength(120)
                .HasDefaultValue("");
            entity.Property(e => e.Centacontable)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Cepa)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Cheque)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Codalmacen)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Codigodoc)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Comentario)
                .HasMaxLength(254)
                .HasDefaultValue("");
            entity.Property(e => e.Comprobantedeliquidacion)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Concepto)
                .HasMaxLength(254)
                .HasDefaultValue("");
            entity.Property(e => e.Condiciondepago)
                .HasMaxLength(60)
                .HasDefaultValue("");
            entity.Property(e => e.Correlativo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Cotrans)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Credito)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Cuenta)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Departamento)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(90)
                .HasDefaultValue("");
            entity.Property(e => e.Descripcionvehiculo)
                .HasMaxLength(130)
                .HasDefaultValue("");
            entity.Property(e => e.Descuento)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Despacho)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Dia)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Diasdecredito)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.DocumentoActivo)
                .HasDefaultValue(true)
                .HasColumnName("Documento_activo");
            entity.Property(e => e.DocumentoCodigo)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .HasColumnName("Documento_codigo");
            entity.Property(e => e.Dui)
                .HasMaxLength(19)
                .HasDefaultValue("");
            entity.Property(e => e.Duionit)
                .HasMaxLength(75)
                .HasDefaultValue("");
            entity.Property(e => e.Eliminado).HasDefaultValue(false);
            entity.Property(e => e.Eliminadopor)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Entradasaexcluidos)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Entradasexentas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Entradasexentasimportaciones)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Entradasexentasinternas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Entradasgravadas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Entradasgravadasimportaciones)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Entradasgravadasinternas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Excenta).HasDefaultValue(true);
            entity.Property(e => e.Extraordinarios)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Factorutilidad)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Fecha).HasDefaultValueSql("('')");
            entity.Property(e => e.FechadeEliminacion).HasDefaultValueSql("('')");
            entity.Property(e => e.Fechadecancelacion).HasDefaultValueSql("('')");
            entity.Property(e => e.Fechadecreacion)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime");
            entity.Property(e => e.Fechadedeclaracion).HasDefaultValueSql("('')");
            entity.Property(e => e.Fechadevencimiento).HasDefaultValueSql("('')");
            entity.Property(e => e.Flete)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Fleteypasaje)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.FormaDePago)
                .HasMaxLength(75)
                .HasDefaultValue("")
                .HasColumnName("Forma_de_pago");
            entity.Property(e => e.Fovial)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Gastopoliza)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Giro)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Gravadasimportaciones)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Gravadasinternas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Guiaaerea)
                .HasMaxLength(120)
                .HasDefaultValue("");
            entity.Property(e => e.Iva)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Ivapercibido)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Nit)
                .HasMaxLength(19)
                .HasDefaultValue("");
            entity.Property(e => e.NoRegistro)
                .HasMaxLength(75)
                .HasDefaultValue("")
                .HasColumnName("No_registro");
            entity.Property(e => e.Noactualizados).HasDefaultValue(true);
            entity.Property(e => e.Nopoliza)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Numero)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Orden)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Otros)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Otrosgl)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Percepcion)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Pesobruto)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Placa)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Proveedorcodigo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Proyecto)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Quedan)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Referencia)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Referenciacheque)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Retencion)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Saldo)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Saldo30)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Saldo60)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Saldo90)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Saldo90ymas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Saldodelafactura)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Salidaddeefectivo)
                .HasMaxLength(80)
                .HasDefaultValue("");
            entity.Property(e => e.Seguro)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Seleccionada).HasDefaultValue(false);
            entity.Property(e => e.Siniva).HasDefaultValue(true);
            entity.Property(e => e.Sumacostofob)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Sumas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Tasadecambio)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Telyfax)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.Tipo)
                .HasMaxLength(60)
                .HasDefaultValue("");
            entity.Property(e => e.Total)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Totalgastosexterior)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Totalgl)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Totalsumas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Transportista)
                .HasMaxLength(120)
                .HasDefaultValue("");
            entity.Property(e => e.Usuario)
                .HasMaxLength(40)
                .HasDefaultValue("");
            entity.Property(e => e.Valordecredito)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Valordescuento)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Valorneto)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.VentaTotal)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)")
                .HasColumnName("Venta_total");
            entity.Property(e => e.Vincular).HasDefaultValue(true);
        });

        modelBuilder.Entity<AjustesDetalle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Entradas_detalles");

            entity.ToTable("Ajustes_detalles");

            entity.Property(e => e.Almacen)
                .HasMaxLength(60)
                .HasDefaultValue("");
            entity.Property(e => e.Cambio)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Cantidad)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Categoria)
                .HasMaxLength(60)
                .HasDefaultValue("");
            entity.Property(e => e.Codalmacen)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Codigo)
                .HasMaxLength(75)
                .HasDefaultValue("");
            entity.Property(e => e.Codigodebarras)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Correlativo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Costoanterior)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Costocondai)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Costodeimportacion)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Costofob)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Costofonanterior)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Costototal)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Costounitario)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Credito)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Cuenta)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Dai)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Descripciondecuenta)
                .HasMaxLength(90)
                .HasDefaultValue("");
            entity.Property(e => e.Descuento)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.DocumentoCodigo)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .HasColumnName("Documento_codigo");
            entity.Property(e => e.Exentas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Factor)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Factorutilidad)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Fecha).HasDefaultValueSql("('')");
            entity.Property(e => e.Fechad).HasDefaultValueSql("('')");
            entity.Property(e => e.Fechadecreacion)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime");
            entity.Property(e => e.Fechadevencimiento).HasDefaultValueSql("('')");
            entity.Property(e => e.Gastoexterior)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Gastoslocales)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Gastospoliza)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Marca)
                .HasMaxLength(120)
                .HasDefaultValue("");
            entity.Property(e => e.Nombre)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Nuevoprecio)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Numero)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Orden)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Placas)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Precio)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.PrecioConIva)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)")
                .HasColumnName("Precio_con_iva");
            entity.Property(e => e.PrecioUni)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)")
                .HasColumnName("Precio_uni");
            entity.Property(e => e.Precioanterior)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Preciodeventa)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(90)
                .HasDefaultValue("");
            entity.Property(e => e.Proveedorcodigo)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Referencia)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Seleccionada).HasDefaultValue(false);
            entity.Property(e => e.Subtotal)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Total)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Ultimocosto)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Unidaddemedida)
                .HasMaxLength(90)
                .HasDefaultValue("");
            entity.Property(e => e.Valorcif)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Valorcifdai)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Valordescuento)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
        });

        modelBuilder.Entity<Almacene>(entity =>
        {
            entity.Property(e => e.Abonosacontratos)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Actualizado).HasDefaultValue(true);
            entity.Property(e => e.Afdebito)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Alias)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Bienesenarrendamiento)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Codigo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Comprascentralizadas).HasDefaultValue(true);
            entity.Property(e => e.Comprasdeinventario)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Comprasexentas)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Correlativoderemesas)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Costodeventadepreciacionabono)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Costodeventadepreciacioncargo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Cotrans)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Creditosccf)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Creditosccfabono)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Creditosfac)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Creditosfacabono)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Cuentadecostos)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Cuentadegastos)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Cuentadeingresos)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Cuentagasto)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Cuentasactivas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Cuentascanceladas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Cuentasdecomisadas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Cuentasnuevas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Cuentasquenopagaron)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Cuentasquepagaron)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Departamento)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Direccion)
                .HasMaxLength(70)
                .HasDefaultValue("");
            entity.Property(e => e.Factor)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Fechadecreacion)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.Fovialcompras)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Fovialventas)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Ingresosporventacontado)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Ingresosporventacredito)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Ivacompras)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Ivadebitofiscalccf)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Ivadebitofiscalfac)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Noreportes).HasDefaultValue(true);
            entity.Property(e => e.Numerodecuentas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Pagosenefectivo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Partidaacumulada)
                .HasMaxLength(90)
                .HasDefaultValue("");
            entity.Property(e => e.Percepcioncompras)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Percepcionventas)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Predeterminado).HasDefaultValue(false);
            entity.Property(e => e.Provisioncompras)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Rebajasydevolucionescompras)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Rebajasydevolucionesventas)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Regaliasventasabono)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Regaliasventascargo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Representante)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Retencioncompras)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Retencionventas)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Salidasparaventa).HasDefaultValue(true);
            entity.Property(e => e.Tcompras)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Tcontado)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Tcredito)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Telefono1)
                .HasMaxLength(20)
                .HasDefaultValue("");
            entity.Property(e => e.Telefono2)
                .HasMaxLength(20)
                .HasDefaultValue("");
            entity.Property(e => e.Ultimoccf)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Ultimofac)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Ultimofacexp)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Ultimofacsim)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Ultimonta)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Ultimontc)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Ultimontd)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Ultimontretencion)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Ventasccf)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Ventasconcontrato).HasDefaultValue(true);
            entity.Property(e => e.Ventasdeexportacion)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Ventasexentas)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Ventasfac)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Ventasnetasccfcredito)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Ventasnetasfaccredito)
                .HasMaxLength(18)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<Alumno>(entity =>
        {
            entity.Property(e => e.AnioLectivo).HasColumnName("ANIO_LECTIVO");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.CodInstitucion)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Coddepartamento)
                .HasMaxLength(4)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Codmunicipio)
                .HasMaxLength(4)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Codpais)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.Cuota).HasColumnName("CUOTA");
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Direccion)
                .HasMaxLength(70)
                .HasDefaultValue("");
            entity.Property(e => e.Dui)
                .HasMaxLength(21)
                .HasDefaultValue("")
                .HasColumnName("DUI");
            entity.Property(e => e.Email)
                .HasMaxLength(90)
                .HasDefaultValue("");
            entity.Property(e => e.Estado).HasColumnName("ESTADO");
            entity.Property(e => e.EstudiantePrimerApellido)
                .HasMaxLength(250)
                .HasColumnName("ESTUDIANTE_PRIMER_APELLIDO");
            entity.Property(e => e.EstudiantePrimerNombre)
                .HasMaxLength(250)
                .HasColumnName("ESTUDIANTE_PRIMER_NOMBRE");
            entity.Property(e => e.EstudianteSegundoApellido)
                .HasMaxLength(250)
                .HasColumnName("ESTUDIANTE_SEGUNDO_APELLIDO");
            entity.Property(e => e.EstudianteSegundoNombre)
                .HasMaxLength(250)
                .HasColumnName("ESTUDIANTE_SEGUNDO_NOMBRE");
            entity.Property(e => e.FechaMatricula)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_MATRICULA");
            entity.Property(e => e.FechaNacimiento).HasColumnName("Fecha_nacimiento");
            entity.Property(e => e.Genero)
                .HasMaxLength(250)
                .HasColumnName("GENERO");
            entity.Property(e => e.IdAlumnos).HasColumnName("ID_ALUMNOS");
            entity.Property(e => e.IdGrado)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ID_GRADO");
            entity.Property(e => e.IdInterno)
                .HasMaxLength(30)
                .HasDefaultValue("")
                .HasColumnName("Id_interno");
            entity.Property(e => e.IdParametro).HasColumnName("ID_PARAMETRO");
            entity.Property(e => e.IdSeccion).HasColumnName("ID_SECCION");
            entity.Property(e => e.Identificador)
                .HasMaxLength(250)
                .HasColumnName("IDENTIFICADOR");
            entity.Property(e => e.Institucion)
                .HasMaxLength(70)
                .HasDefaultValue("");
            entity.Property(e => e.Nie)
                .HasMaxLength(250)
                .HasColumnName("NIE");
            entity.Property(e => e.Nit)
                .HasMaxLength(21)
                .HasDefaultValue("")
                .HasColumnName("NIT");
            entity.Property(e => e.Nombre)
                .HasMaxLength(80)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.NombreFactura)
                .HasMaxLength(90)
                .HasDefaultValue("")
                .HasColumnName("Nombre_factura");
            entity.Property(e => e.NombreGrado)
                .HasMaxLength(250)
                .HasColumnName("NOMBRE_GRADO");
            entity.Property(e => e.Pais)
                .HasMaxLength(70)
                .HasDefaultValue("");
            entity.Property(e => e.Religion)
                .HasMaxLength(250)
                .HasColumnName("RELIGION");
            entity.Property(e => e.Telefono).HasMaxLength(30);
            entity.Property(e => e.TipoIngreso).HasColumnName("TIPO_INGRESO");
            entity.Property(e => e.Turno)
                .HasMaxLength(250)
                .HasColumnName("TURNO");
        });

        modelBuilder.Entity<Aperturadecaja>(entity =>
        {
            entity.HasKey(e => e.IdAperturadecaja);

            entity.ToTable("Aperturadecaja");

            entity.Property(e => e.FechadeApertura).HasDefaultValueSql("('')");
            entity.Property(e => e.SaldoInicial).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<AppUser>(entity =>
        {
            entity.HasKey(e => e.IdUser);

            entity.ToTable("AppUser");

            entity.Property(e => e.Almacen)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Caja)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Cargo)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.CodInstitucion)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.CodigodeAlmacen)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Confirmacion).HasMaxLength(50);
            entity.Property(e => e.Dui)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Eliminado).HasDefaultValue(false);
            entity.Property(e => e.FechaCreado)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.Grupo)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Imagen).HasMaxLength(100);
            entity.Property(e => e.ImprimirReportes).HasDefaultValue(false);
            entity.Property(e => e.Institucion)
                .HasMaxLength(70)
                .HasDefaultValue("");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Pc)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("PC");
            entity.Property(e => e.SueperContraseña).HasMaxLength(50);
            entity.Property(e => e.UserFave)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.UserLavel).HasDefaultValue(0);
            entity.Property(e => e.UserLevel)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.UserMacro)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.UserNotes)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.UserPass).HasMaxLength(50);
            entity.Property(e => e.UserRopts)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Username2)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.UsuarioCreado)
                .HasMaxLength(50)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<Asociado>(entity =>
        {
            entity.Property(e => e.Actanum)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.Activo).HasDefaultValue(false);
            entity.Property(e => e.Afiliacionnum)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Apellidosasociado1)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Apellidosasociado2)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Asociadonum1)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.Asociadonum2)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.Cargodesempeñado)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Categoriacomunitario).HasDefaultValue(false);
            entity.Property(e => e.Categoriacontribuyente).HasDefaultValue(false);
            entity.Property(e => e.Categoriajuvenil).HasDefaultValue(false);
            entity.Property(e => e.Categorianieto).HasDefaultValue(false);
            entity.Property(e => e.Categorianumero).HasDefaultValue(false);
            entity.Property(e => e.Categoriatranseunte).HasDefaultValue(false);
            entity.Property(e => e.Celular)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Celularcompañia)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centroespañol)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(75)
                .HasDefaultValue("");
            entity.Property(e => e.Ciudadcompañia)
                .HasMaxLength(75)
                .HasDefaultValue("");
            entity.Property(e => e.Claseaprobacion)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Codigo).HasMaxLength(50);
            entity.Property(e => e.Departamento)
                .HasMaxLength(75)
                .HasDefaultValue("");
            entity.Property(e => e.Departamentocompañia)
                .HasMaxLength(75)
                .HasDefaultValue("");
            entity.Property(e => e.Direccioncompañia)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Domicilio)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Edad)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(2, 0)");
            entity.Property(e => e.Edadbenef1)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(2, 0)");
            entity.Property(e => e.Edadbenef2)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(2, 0)");
            entity.Property(e => e.Edadbenef3)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(2, 0)");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Emailcompañia)
                .HasMaxLength(75)
                .HasDefaultValue("");
            entity.Property(e => e.Emaildos).HasMaxLength(50);
            entity.Property(e => e.Estadocivil)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Faxcompañia)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Fechaaprobacion).HasDefaultValueSql("('')");
            entity.Property(e => e.Fechacentroespañol).HasDefaultValueSql("('')");
            entity.Property(e => e.Fechadecreacion)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.Fechadenacimiento).HasDefaultValueSql("('')");
            entity.Property(e => e.Fechanacimientoabuelos1).HasDefaultValueSql("('')");
            entity.Property(e => e.Fechanacimientoabuelos2).HasDefaultValueSql("('')");
            entity.Property(e => e.Fechanacimientobenef1).HasDefaultValueSql("('')");
            entity.Property(e => e.Fechanacimientobenef2).HasDefaultValueSql("('')");
            entity.Property(e => e.Fechanacimientobenef3).HasDefaultValueSql("('')");
            entity.Property(e => e.Fechasolicitud).HasDefaultValueSql("('')");
            entity.Property(e => e.Giro)
                .HasMaxLength(70)
                .HasDefaultValue("");
            entity.Property(e => e.Keyid).HasMaxLength(50);
            entity.Property(e => e.Lugardenacimiento)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Lugarnacimientoabuelos1)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Lugarnacimientoabuelos2)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Lugarnacimientobenef1)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Lugarnacimientobenef2)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Lugarnacimientobenef3)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Municipio)
                .HasMaxLength(75)
                .HasDefaultValue("");
            entity.Property(e => e.Municipiocompañia)
                .HasMaxLength(75)
                .HasDefaultValue("");
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Nit)
                .HasMaxLength(18)
                .HasDefaultValue("")
                .HasColumnName("NIT");
            entity.Property(e => e.Nombrecompañia)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Nombres)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Nombresabuelos1)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Nombresabuelos2)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Nombresasociado1)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Nombresasociado2)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Nombresbenef1)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Nombresbenef2)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Nombresbenef3)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Nrc)
                .HasMaxLength(12)
                .HasDefaultValue("")
                .HasColumnName("NRC");
            entity.Property(e => e.Parentesco1)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.Parentesco2)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.Parentescobenef1)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.Parentescobenef2)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Parentescobenef3)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.Profesion)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Sexo)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Solicitante)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Telefonoasociado1)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Telefonoasociado2)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Telefonocompañia)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Usuario)
                .HasMaxLength(150)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<AspNetRole>(entity =>
        {
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetRoleClaim>(entity =>
        {
            entity.Property(e => e.RoleId).HasMaxLength(450);

            entity.HasOne(d => d.Role).WithMany(p => p.AspNetRoleClaims).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<AspNetUser>(entity =>
        {
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRole",
                    r => r.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId"),
                    l => l.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId");
                        j.ToTable("AspNetUserRoles");
                    });
        });

        modelBuilder.Entity<AspNetUserClaim>(entity =>
        {
            entity.Property(e => e.UserId).HasMaxLength(450);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.ProviderKey).HasMaxLength(128);
            entity.Property(e => e.UserId).HasMaxLength(450);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserToken>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.Name).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserTokens).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<Banco>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CodigoTransferencia)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .HasColumnName("Codigo_Transferencia");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<Beneficiario>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Activo).HasDefaultValue(false);
            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Edad)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(2, 0)");
            entity.Property(e => e.Fechadecreacion)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.Fechadenacimiento).HasDefaultValueSql("('')");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Idasociado).HasDefaultValue(0);
            entity.Property(e => e.Lugardenacimiento)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Parentesco)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<Bitacora>(entity =>
        {
            entity.ToTable("Bitacora");

            entity.Property(e => e.Creado)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Keydocumento)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Modulo)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Opcionprincipal)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Opcionsecundaria)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<Caja>(entity =>
        {
            entity.HasKey(e => e.Cajasid);

            entity.Property(e => e.Autorizacionnumero)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Caja1)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("Caja");
            entity.Property(e => e.CodEstablecimientoMh)
                .HasMaxLength(12)
                .HasDefaultValue("")
                .HasColumnName("CodEstablecimientoMH");
            entity.Property(e => e.CodInstitucion).HasMaxLength(30);
            entity.Property(e => e.CodPuntoVentaMh)
                .HasMaxLength(12)
                .HasDefaultValue("")
                .HasColumnName("codPuntoVentaMH");
            entity.Property(e => e.Contacto)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Departamento)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Documentoencargado)
                .HasMaxLength(22)
                .HasDefaultValue("");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.EncargadodeFacturacion)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.Institucion).HasMaxLength(70);
            entity.Property(e => e.Municipio)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Notas).HasDefaultValue("");
            entity.Property(e => e.PasswordEmail)
                .HasMaxLength(75)
                .HasDefaultValue("");
            entity.Property(e => e.Pc)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("PC");
            entity.Property(e => e.Pc2)
                .HasMaxLength(50)
                .HasColumnName("PC2");
            entity.Property(e => e.Resolucionnumero)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Serieal)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Seriedel)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.SistemaInstalado).HasDefaultValue(false);
            entity.Property(e => e.Telefono1)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Telefono2)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Telefonocontacto)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Tipo)
                .HasMaxLength(20)
                .HasDefaultValue("");
            entity.Property(e => e.Ultimocortex).HasDefaultValue(0);
            entity.Property(e => e.Ultimocortez).HasDefaultValue(0);
            entity.Property(e => e.Ultimocortezmensual).HasDefaultValue(0);
        });

        modelBuilder.Entity<Cajero>(entity =>
        {
            entity.Property(e => e.Codigo).HasMaxLength(18);
            entity.Property(e => e.Codigodeempleado).HasMaxLength(18);
            entity.Property(e => e.Nombre).HasMaxLength(150);
        });

        modelBuilder.Entity<Cargosusuario>(entity =>
        {
            entity.HasKey(e => e.CargosusuariosId);

            entity.Property(e => e.Cargo)
                .HasMaxLength(50)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.Property(e => e.Codigo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Comisiondos)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Comisionuno)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .HasDefaultValue("");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<ClasificacionTributarium>(entity =>
        {
            entity.HasKey(e => e.ClasificacionTributaria);

            entity.ToTable("Clasificacion_Tributaria");

            entity.Property(e => e.ClasificacionTributaria)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Clasificacion_Tributaria");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Clientes_1");

            entity.Property(e => e.Categoria)
                .HasMaxLength(90)
                .HasDefaultValue("");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.Clasificacion)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.Cliente1)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("Cliente");
            entity.Property(e => e.Clientedeservicio).HasDefaultValue(false);
            entity.Property(e => e.Clienteexento).HasDefaultValue(false);
            entity.Property(e => e.CodActividad)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.CodDepartamento)
                .HasMaxLength(4)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.CodInstitucion)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.CodMunicipio)
                .HasMaxLength(4)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Codigo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Codigocontigencia)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Codigodealmacen)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Codpais)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("codpais");
            entity.Property(e => e.Comentarios)
                .HasMaxLength(200)
                .HasDefaultValue("");
            entity.Property(e => e.Contacto)
                .HasMaxLength(90)
                .HasDefaultValue("");
            entity.Property(e => e.Creado)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.Creditoactivo).HasDefaultValue(false);
            entity.Property(e => e.Cuenta)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Departamento)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Descuento)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Diasdecredito)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.DireccionEntrega)
                .HasMaxLength(100)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Direcciondos)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Direcciontres)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Dui)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Escaladeprecio)
                .HasMaxLength(1)
                .HasDefaultValue("");
            entity.Property(e => e.Estado)
                .HasMaxLength(10)
                .HasDefaultValue("");
            entity.Property(e => e.Extranjero).HasDefaultValue(false);
            entity.Property(e => e.Fechadeultimopago)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime");
            entity.Property(e => e.FormaPago)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("Forma_Pago");
            entity.Property(e => e.Gestionado)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Giro)
                .HasMaxLength(175)
                .HasDefaultValue("");
            entity.Property(e => e.Grupo)
                .HasMaxLength(90)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.Iniciales)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Interes)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.LimiteCredito)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)")
                .HasColumnName("Limite_credito");
            entity.Property(e => e.Nit)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.NoRegistro)
                .HasMaxLength(30)
                .HasDefaultValue("")
                .HasColumnName("No_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(125)
                .HasDefaultValue("");
            entity.Property(e => e.NombreComercial)
                .HasMaxLength(254)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Pais)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Recinto)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Regimen)
                .HasMaxLength(16)
                .HasDefaultValue("");
            entity.Property(e => e.Saldo)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Saldoinicial)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Subcategoria)
                .HasMaxLength(90)
                .HasDefaultValue("");
            entity.Property(e => e.Sucursal)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Sujetodepercepcion).HasDefaultValue(false);
            entity.Property(e => e.Sujetopercepcion).HasDefaultValue(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Telefonoc)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Tipo)
                .HasMaxLength(20)
                .HasDefaultValue("");
            entity.Property(e => e.TipoCliente)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .HasColumnName("Tipo_cliente");
            entity.Property(e => e.Usuario)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.Vendedor)
                .HasMaxLength(50)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<ClientesInterno>(entity =>
        {
            entity.ToTable("Clientes_internos");

            entity.Property(e => e.Codigo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Nombre)
                .HasMaxLength(90)
                .HasDefaultValue("");
            entity.Property(e => e.Telefono)
                .HasMaxLength(9)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<Compra>(entity =>
        {
            entity.Property(e => e.Agenteaduanal)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Almacen)
                .HasMaxLength(75)
                .HasDefaultValue("");
            entity.Property(e => e.Anulada).HasDefaultValue(false);
            entity.Property(e => e.Aplicarpercepcion).HasDefaultValue(true);
            entity.Property(e => e.Aplicarretencion).HasDefaultValue(true);
            entity.Property(e => e.Bultos)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Calculos).HasDefaultValue(true);
            entity.Property(e => e.Cancelada).HasDefaultValue(true);
            entity.Property(e => e.Categoria)
                .HasMaxLength(120)
                .HasDefaultValue("");
            entity.Property(e => e.Centacontable)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Cepa)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Cheque)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Codalmacen)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Codigodoc)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Comentario)
                .HasMaxLength(254)
                .HasDefaultValue("");
            entity.Property(e => e.Comprasaexcluidos)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Comprasexentas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Comprasexentasimportaciones)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Comprasexentasinternas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Comprasgravadas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Comprasgravadasimportaciones)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Comprasgravadasinternas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Comprobantedeliquidacion)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Concepto)
                .HasMaxLength(254)
                .HasDefaultValue("");
            entity.Property(e => e.Condiciondepago)
                .HasMaxLength(60)
                .HasDefaultValue("");
            entity.Property(e => e.Correlativo)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.Cotrans)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Credito)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Cuenta)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Departamento)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(90)
                .HasDefaultValue("");
            entity.Property(e => e.Descripcionvehiculo)
                .HasMaxLength(130)
                .HasDefaultValue("");
            entity.Property(e => e.Descuento)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Despacho)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Dia)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Diasdecredito)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Diasdevencido)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.DocumentoActivo)
                .HasDefaultValue(true)
                .HasColumnName("Documento_activo");
            entity.Property(e => e.DocumentoCodigo)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .HasColumnName("Documento_codigo");
            entity.Property(e => e.Dui)
                .HasMaxLength(19)
                .HasDefaultValue("");
            entity.Property(e => e.Duionit)
                .HasMaxLength(75)
                .HasDefaultValue("");
            entity.Property(e => e.Eliminado).HasDefaultValue(false);
            entity.Property(e => e.Eliminadopor)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Excenta).HasDefaultValue(true);
            entity.Property(e => e.Extraordinarios)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Factorutilidad)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Fecha).HasDefaultValueSql("('')");
            entity.Property(e => e.FechadeEliminacion).HasDefaultValueSql("('')");
            entity.Property(e => e.Fechadecancelacion).HasDefaultValueSql("('')");
            entity.Property(e => e.Fechadecreacion)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime");
            entity.Property(e => e.Fechadedeclaracion).HasDefaultValueSql("('')");
            entity.Property(e => e.Fechadevencimiento).HasDefaultValueSql("('')");
            entity.Property(e => e.Flete)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Fleteypasaje)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.FormaDePago)
                .HasMaxLength(75)
                .HasDefaultValue("")
                .HasColumnName("Forma_de_pago");
            entity.Property(e => e.Fovial)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Gastopoliza)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Giro)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Gravadasimportaciones)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Gravadasinternas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Guiaaerea)
                .HasMaxLength(120)
                .HasDefaultValue("");
            entity.Property(e => e.Iva)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Ivapercibido)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Nit)
                .HasMaxLength(19)
                .HasDefaultValue("");
            entity.Property(e => e.NoRegistro)
                .HasMaxLength(75)
                .HasDefaultValue("")
                .HasColumnName("No_registro");
            entity.Property(e => e.Noactualizados).HasDefaultValue(true);
            entity.Property(e => e.Nopoliza)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Numero)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Numeroderesolucion)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.Orden)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Otros)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Otrosgl)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Percepcion)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Pesobruto)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Placa)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Proveedorcodigo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Proyecto)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Quedan)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Referencia)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Referenciacheque)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Retencion)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Saldo)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Saldo30)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Saldo60)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Saldo90)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Saldo90ymas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Saldodelafactura)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Salidaddeefectivo)
                .HasMaxLength(80)
                .HasDefaultValue("");
            entity.Property(e => e.Sectorrenta)
                .HasMaxLength(70)
                .HasDefaultValue("");
            entity.Property(e => e.Seguro)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Seleccionada).HasDefaultValue(false);
            entity.Property(e => e.Serienumero)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.Siniva).HasDefaultValue(true);
            entity.Property(e => e.Sumacostofob)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Sumas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Tasadecambio)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Telyfax)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.Tipo)
                .HasMaxLength(60)
                .HasDefaultValue("");
            entity.Property(e => e.Tipocostogasto)
                .HasMaxLength(70)
                .HasDefaultValue("");
            entity.Property(e => e.Tipodeoperacion)
                .HasMaxLength(70)
                .HasDefaultValue("");
            entity.Property(e => e.Total)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Totalgastosexterior)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Totalgl)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Totalsumas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Transportista)
                .HasMaxLength(120)
                .HasDefaultValue("");
            entity.Property(e => e.Usuario)
                .HasMaxLength(40)
                .HasDefaultValue("");
            entity.Property(e => e.Valordecredito)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Valordescuento)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Valorneto)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.VentaTotal)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)")
                .HasColumnName("Venta_total");
            entity.Property(e => e.Vincular).HasDefaultValue(true);
        });

        modelBuilder.Entity<ComprasDetalle>(entity =>
        {
            entity.ToTable("Compras_detalles");

            entity.Property(e => e.Almacen)
                .HasMaxLength(60)
                .HasDefaultValue("");
            entity.Property(e => e.Cambio)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Cantidad)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Categoria)
                .HasMaxLength(60)
                .HasDefaultValue("");
            entity.Property(e => e.Codalmacen)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Codigo)
                .HasMaxLength(75)
                .HasDefaultValue("");
            entity.Property(e => e.Correlativo)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.Costoanterior)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Costocondai)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Costodeimportacion)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Costofob)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Costofonanterior)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Costototal)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Costounitario)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Credito)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Cuenta)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Dai)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Descripciondecuenta)
                .HasMaxLength(90)
                .HasDefaultValue("");
            entity.Property(e => e.Descuento)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.DocumentoCodigo)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .HasColumnName("Documento_codigo");
            entity.Property(e => e.Exentas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Factor)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Factorutilidad)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Fecha).HasDefaultValueSql("('')");
            entity.Property(e => e.Fechad).HasDefaultValueSql("('')");
            entity.Property(e => e.Fechadecreacion)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime");
            entity.Property(e => e.Fechadevencimiento).HasDefaultValueSql("('')");
            entity.Property(e => e.Gastoexterior)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Gastoslocales)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Gastospoliza)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Marca)
                .HasMaxLength(120)
                .HasDefaultValue("");
            entity.Property(e => e.Nombre)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Nuevoprecio)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Numero)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Orden)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Placas)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Precio)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.PrecioConIva)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)")
                .HasColumnName("Precio_con_iva");
            entity.Property(e => e.PrecioUni)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)")
                .HasColumnName("Precio_uni");
            entity.Property(e => e.Precioanterior)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Preciodeventa)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(90)
                .HasDefaultValue("");
            entity.Property(e => e.Proveedorcodigo)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Referencia)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Seleccionada).HasDefaultValue(false);
            entity.Property(e => e.Subtotal)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Total)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Ultimocosto)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Unidaddemedida)
                .HasMaxLength(90)
                .HasDefaultValue("");
            entity.Property(e => e.Valorcif)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Valorcifdai)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Valordescuento)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
        });

        modelBuilder.Entity<Configcuota>(entity =>
        {
            entity.Property(e => e.Categoria)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Cuota)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Donacion)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Donacioncasacomp)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Membresia)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Pagadonacion).HasDefaultValue(false);
            entity.Property(e => e.Pagamembresia).HasDefaultValue(false);
            entity.Property(e => e.Prefijo)
                .HasMaxLength(2)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<Contingencia>(entity =>
        {
            entity.HasKey(e => e.ContingenciasId);

            entity.Property(e => e.ContingenciasId).HasColumnName("ContingenciasID");
            entity.Property(e => e.Activa).HasDefaultValue(false);
            entity.Property(e => e.Codigo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Fechafin).HasColumnType("datetime");
            entity.Property(e => e.Fechainicio).HasColumnType("datetime");
            entity.Property(e => e.Horafin)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Horainicio)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Motivo).HasMaxLength(250);
            entity.Property(e => e.Tipo)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(1, 0)");
        });

        modelBuilder.Entity<Contribuyente>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Alias)
                .HasMaxLength(255)
                .HasColumnName("ALIAS");
            entity.Property(e => e.Apellido1)
                .HasMaxLength(255)
                .HasColumnName("APELLIDO1");
            entity.Property(e => e.Apellido2)
                .HasMaxLength(255)
                .HasColumnName("APELLIDO2");
            entity.Property(e => e.Departamento)
                .HasMaxLength(255)
                .HasColumnName("DEPARTAMENTO");
            entity.Property(e => e.Derecha)
                .HasMaxLength(255)
                .HasColumnName("derecha");
            entity.Property(e => e.Direccion)
                .HasMaxLength(255)
                .HasColumnName("DIRECCION");
            entity.Property(e => e.F8).HasMaxLength(255);
            entity.Property(e => e.F9).HasMaxLength(255);
            entity.Property(e => e.Giro)
                .HasMaxLength(255)
                .HasColumnName("GIRO");
            entity.Property(e => e.Izquierda)
                .HasMaxLength(255)
                .HasColumnName("izquierda");
            entity.Property(e => e.Municipio)
                .HasMaxLength(255)
                .HasColumnName("MUNICIPIO");
            entity.Property(e => e.Nit)
                .HasMaxLength(30)
                .HasColumnName("NIT");
            entity.Property(e => e.Nit1)
                .HasMaxLength(255)
                .HasColumnName("NIT1");
            entity.Property(e => e.Nit2)
                .HasMaxLength(255)
                .HasColumnName("NIT2");
            entity.Property(e => e.Nit3)
                .HasMaxLength(255)
                .HasColumnName("NIT3");
            entity.Property(e => e.Nit4)
                .HasMaxLength(255)
                .HasColumnName("NIT4");
            entity.Property(e => e.NitMalo)
                .HasMaxLength(255)
                .HasColumnName("NIT_malo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(255)
                .HasColumnName("RAZON_SOCIAL");
            entity.Property(e => e.Registro).HasColumnName("REGISTRO");
            entity.Property(e => e.RegistroLevi)
                .HasMaxLength(18)
                .HasColumnName("REGISTRO_LEVI");
            entity.Property(e => e.Telefono)
                .HasMaxLength(255)
                .HasColumnName("TELEFONO");
        });

        modelBuilder.Entity<Correlativo>(entity =>
        {
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Ultimo).HasDefaultValue(0);
        });

        modelBuilder.Entity<CorrelativoAjuste>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CorrelativoAjuste");

            entity.Property(e => e.Activo).HasDefaultValue(false);
            entity.Property(e => e.Ajusteno).HasDefaultValue(0);
            entity.Property(e => e.Idcorrelativoajuste).ValueGeneratedOnAdd();
            entity.Property(e => e.Inventariono).HasDefaultValue(0);
        });

        modelBuilder.Entity<CorrelativosDocumento>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Caja).HasMaxLength(10);
            entity.Property(e => e.Codigodealmacen)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Codigodedocumento).HasMaxLength(18);
            entity.Property(e => e.Creado).HasColumnType("datetime");
            entity.Property(e => e.Documento).HasMaxLength(50);
            entity.Property(e => e.Idcorredocu).ValueGeneratedOnAdd();
            entity.Property(e => e.NumerodeSerie).HasMaxLength(30);
            entity.Property(e => e.Resolucionhacienda).HasMaxLength(30);
            entity.Property(e => e.Ultimocorrelativo).HasMaxLength(18);
            entity.Property(e => e.Usuario).HasMaxLength(50);
        });

        modelBuilder.Entity<Correlativoso>(entity =>
        {
            entity.ToTable("Correlativoso");

            entity.Property(e => e.Comanda)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Numero)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<Cortemv>(entity =>
        {
            entity.HasKey(e => e.IdCortemv);

            entity.ToTable("Cortemv");

            entity.Property(e => e.BitCoin)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Caja)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Ccfdesde)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("CCFdesde");
            entity.Property(e => e.Ccfhasta)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("CCFhasta");
            entity.Property(e => e.CodigodeAlmacen)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.FacturaDesde)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.FacturaHasta)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Fecha).HasDefaultValueSql("('')");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechadeCreacion).HasDefaultValueSql("('')");
            entity.Property(e => e.Numero)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Tarjeta)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.TicketDesde)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.TicketHasta)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.TicketdDesde)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.TicketdHasta)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.TotalDevolucion)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.TotalGabeta)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.TotalVentaNeta)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.TotalVentas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.TotalVentasGravadas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.TotaldeTicket)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.TotaldeTicketExentos)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.TotaldeTicketGravados)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Totaliva)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Transferencia)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.UltimoTicket)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.UltimoTicketAnterior)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Ultimoccf)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.VentasConTicket)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.VentasconFactura)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Ventasconccf)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
        });

        modelBuilder.Entity<Cortex>(entity =>
        {
            entity.HasKey(e => e.IdCortex);

            entity.ToTable("Cortex");

            entity.Property(e => e.BitCoin)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Caja)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Ccfdesde)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("CCFDesde");
            entity.Property(e => e.Ccfhasta)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("CCFHasta");
            entity.Property(e => e.CodigodeAlmacen)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.FacturaDesde)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.FacturaHasta)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Fecha).HasDefaultValueSql("('')");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechadeCreacion).HasDefaultValueSql("('')");
            entity.Property(e => e.Numero)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Tarjeta)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.TicketDesde)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.TicketHasta)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.TicketdDesde)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.TicketdHasta)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.TotalDevoluciones)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.TotalGabeta)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.TotalVentaNeta)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.TotalVentas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.TotalVentasGravadas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.TotaldeTicket)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.TotaldeTicketExentos)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.TotaldeTicketGravados)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Totaliva)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Transferencia)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.UltimoTicket)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.UltimoTicketAnterior)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Ultimoccf)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.VentasConTicket)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.VentasconFactura)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Ventasconccf)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
        });

        modelBuilder.Entity<Cortez>(entity =>
        {
            entity.HasKey(e => e.IdCorteZ);

            entity.ToTable("Cortez");

            entity.Property(e => e.Bitcoin)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Caja)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Ccfdesde)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("CCFDesde");
            entity.Property(e => e.Ccfhasta)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("CCFHasta");
            entity.Property(e => e.CodigodeAlmacen)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.FacturaDesde)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.FacturaHasta)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Fecha).HasDefaultValueSql("('')");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechadeCreacion)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime");
            entity.Property(e => e.Numero)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Tarjeta)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.TicketDesde)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.TicketHasta)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.TicketdDesde)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.TicketdHasta)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.TotalDevoluciones)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.TotalGabeta)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.TotalIva)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)")
                .HasColumnName("TotalIVA");
            entity.Property(e => e.TotalVenta)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.TotalVentaNeta)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.TotalVentas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.TotalVentasGravadas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.TotaldeTicket)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.TotaldeTicketExentos)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.TotaldeTicketGravados)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Transferencia)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.UltimoCcf)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("UltimoCCF");
            entity.Property(e => e.UltimoTicket)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.UltimoTicketAnterior)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.VentasConFactura)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.VentasconCcf)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)")
                .HasColumnName("VentasconCCF");
            entity.Property(e => e.VentasconTicket)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
        });

        modelBuilder.Entity<Cotizacion>(entity =>
        {
            entity.ToTable("Cotizacion");

            entity.Property(e => e.Abono)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Actualizada).HasDefaultValue(true);
            entity.Property(e => e.Almacencodigo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Anuladopor)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Aplicaretencion).HasDefaultValue(true);
            entity.Property(e => e.Aplicarpercepcion).HasDefaultValue(true);
            entity.Property(e => e.Atencion)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.Autorizadopor)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Banco)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Caja)
                .HasMaxLength(10)
                .HasDefaultValue("");
            entity.Property(e => e.Cancelada).HasDefaultValue(false);
            entity.Property(e => e.Categoria)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Categoriadeventa)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Chequenumero)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Clasificasion)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Cliente)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Clientecodigo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Clienteexento).HasDefaultValue(false);
            entity.Property(e => e.Codigo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.CodigoVendedor)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Comentario)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Concepto)
                .HasMaxLength(90)
                .HasDefaultValue("");
            entity.Property(e => e.Correlativo)
                .HasMaxLength(10)
                .HasDefaultValue("");
            entity.Property(e => e.Correlativohasta)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Departamento)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Descuento)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Descuentodelacuenta)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 9)");
            entity.Property(e => e.Diasdecredito)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Documento)
                .HasMaxLength(75)
                .HasDefaultValue("");
            entity.Property(e => e.Documentoactivo).HasDefaultValue(false);
            entity.Property(e => e.Documentocodigo).HasMaxLength(30);
            entity.Property(e => e.Dui)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Eliminado).HasDefaultValue(false);
            entity.Property(e => e.Eliminadopor)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Exentas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Exportaciones)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Exportacionesfuera)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Exportacionesregion)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Fecha).HasDefaultValueSql("('')");
            entity.Property(e => e.FechaReferencia).HasDefaultValueSql("('')");
            entity.Property(e => e.Fechadeanulacion)
                .HasDefaultValueSql("((0))")
                .HasColumnType("datetime");
            entity.Property(e => e.Fechadecancelacion).HasDefaultValueSql("('')");
            entity.Property(e => e.Fechadecancelado)
                .HasDefaultValueSql("((0))")
                .HasColumnType("datetime");
            entity.Property(e => e.Fechadecreacion)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.Fechadeeliminacion)
                .HasDefaultValueSql("((0))")
                .HasColumnType("datetime");
            entity.Property(e => e.Fechadevencimiento).HasDefaultValueSql("('')");
            entity.Property(e => e.FormaDePago)
                .HasMaxLength(30)
                .HasDefaultValue("")
                .HasColumnName("Forma_de_pago");
            entity.Property(e => e.Fovial)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Giro)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Gravadas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Gravadasaconsumidores)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Gravadasconsumidores)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Iva)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Ivapercibido)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Ivaretenido)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Nit)
                .HasMaxLength(25)
                .HasDefaultValue("");
            entity.Property(e => e.NoRegistro)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("No_registro");
            entity.Property(e => e.Notaderemision)
                .HasMaxLength(4)
                .HasDefaultValue("");
            entity.Property(e => e.Notas)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Notasdos)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Numero)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Referencia)
                .HasMaxLength(18)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.Remesa)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Retencion).HasDefaultValue(true);
            entity.Property(e => e.Saldo)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Saldodelafactura)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Subtotal)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Sucursal)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Sujetodepercepcion).HasDefaultValue(false);
            entity.Property(e => e.Sumas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Tarjeta)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Telefono)
                .HasMaxLength(25)
                .HasDefaultValue("");
            entity.Property(e => e.Telefono2)
                .HasMaxLength(25)
                .HasDefaultValue("");
            entity.Property(e => e.Telefonocheque)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Total)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Transferencia)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Usuario)
                .HasMaxLength(40)
                .HasDefaultValue("");
            entity.Property(e => e.Valor)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.ValorNeto)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)")
                .HasColumnName("Valor_neto");
            entity.Property(e => e.Valordeldescuento)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Valorretencion)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Vcontado)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Vcredito)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Vendedor)
                .HasMaxLength(60)
                .HasDefaultValue("");
            entity.Property(e => e.VentaTotal)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)")
                .HasColumnName("Venta_total");
            entity.Property(e => e.Ventaexenta)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Ventasexentas).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Ventassiniva)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Zonasydpa)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
        });

        modelBuilder.Entity<CotizacionDetalle>(entity =>
        {
            entity.ToTable("Cotizacion_detalles");

            entity.Property(e => e.Almacenalias)
                .HasMaxLength(40)
                .HasDefaultValue("");
            entity.Property(e => e.Almacencodigo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Barra)
                .HasMaxLength(60)
                .HasDefaultValue("");
            entity.Property(e => e.Cantidad)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Categoria)
                .HasMaxLength(90)
                .HasDefaultValue("");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasDefaultValue("");
            entity.Property(e => e.Correlativo)
                .HasMaxLength(10)
                .HasDefaultValue("");
            entity.Property(e => e.Costo)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Costodeimportacion)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Descuento)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Documentocodigo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Facturacion)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Facturaoccf)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Fechadecreacion)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.Item)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Margen)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Nombre)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Nosujetas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Notaderemision)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.PrecioConIva)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)")
                .HasColumnName("Precio_con_iva");
            entity.Property(e => e.PrecioUni)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)")
                .HasColumnName("Precio_uni");
            entity.Property(e => e.Preciosindescuento)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 9)");
            entity.Property(e => e.Preciosiniva)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Productocodigo)
                .HasMaxLength(75)
                .HasDefaultValue("");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(200)
                .HasDefaultValue("");
            entity.Property(e => e.Referencia)
                .HasMaxLength(40)
                .HasDefaultValue("");
            entity.Property(e => e.Serie).HasDefaultValue(true);
            entity.Property(e => e.Servicio).HasDefaultValue(true);
            entity.Property(e => e.Subtotal)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Unidaddemedida)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Ventaexenta)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Ventasafectas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Ventasexenta)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");

            entity.HasOne(d => d.Cotizacion).WithMany(p => p.CotizacionDetalles)
                .HasForeignKey(d => d.CotizacionId)
                .HasConstraintName("FK_Cotizacion_detalles_Cotizacion");
        });

        modelBuilder.Entity<Cuenta>(entity =>
        {
            entity.Property(e => e.Numero).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Orde).HasMaxLength(30);
            entity.Property(e => e.Valor).HasColumnType("numeric(18, 9)");
        });

        modelBuilder.Entity<Cuota>(entity =>
        {
            entity.Property(e => e.AlumnoId).HasDefaultValue(0);
            entity.Property(e => e.Cancelada).HasDefaultValue(false);
            entity.Property(e => e.CodInstitucion)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Codigo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Cuota1)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)")
                .HasColumnName("Cuota");
            entity.Property(e => e.CuotaNumero)
                .HasDefaultValue(0)
                .HasColumnName("Cuota_Numero");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(70)
                .HasDefaultValue("");
            entity.Property(e => e.Mes)
                .HasMaxLength(12)
                .HasDefaultValue("");
            entity.Property(e => e.Referencia)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Seleccionada).HasDefaultValue(false);
            entity.Property(e => e.YearElectivo)
                .HasDefaultValue(0)
                .HasColumnName("Year_Electivo");
        });

        modelBuilder.Entity<Cxc>(entity =>
        {
            entity.ToTable("cxc");

            entity.Property(e => e.Abono)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Anombrede)
                .HasMaxLength(120)
                .HasDefaultValue("");
            entity.Property(e => e.Cancelada).HasDefaultValue(false);
            entity.Property(e => e.Correlativo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Direccion)
                .HasMaxLength(120)
                .HasDefaultValue("");
            entity.Property(e => e.Documento)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Fechadecreacion)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.Fechadevencimiento).HasColumnType("datetime");
            entity.Property(e => e.Idasociado).HasDefaultValue(0);
            entity.Property(e => e.Iddocumento)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Idperiodo)
                .HasMaxLength(8)
                .HasDefaultValue("");
            entity.Property(e => e.Nombre)
                .HasMaxLength(120)
                .HasDefaultValue("");
            entity.Property(e => e.Saldo)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Valor)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
        });

        modelBuilder.Entity<DatosFiscale>(entity =>
        {
            entity.HasKey(e => e.IdDatosFiscales).HasName("PK_DATOSFISCALES");

            entity.Property(e => e.Auditor).HasMaxLength(250);
            entity.Property(e => e.Contador).HasMaxLength(250);
            entity.Property(e => e.Dui)
                .HasMaxLength(50)
                .HasColumnName("DUI");
            entity.Property(e => e.Fechadecreacion).HasColumnType("datetime");
            entity.Property(e => e.Giro).HasMaxLength(250);
            entity.Property(e => e.Nit)
                .HasMaxLength(50)
                .HasColumnName("NIT");
            entity.Property(e => e.NoInscripcionContador).HasMaxLength(100);
            entity.Property(e => e.NoInscriptorAuditor).HasMaxLength(100);
            entity.Property(e => e.RepresentanteLegal).HasMaxLength(250);
        });

        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.ToTable("Departamento");

            entity.Property(e => e.DepartamentoId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Departamento_Id");
            entity.Property(e => e.Departamento1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Departamento");
        });

        modelBuilder.Entity<Departamento1>(entity =>
        {
            entity.ToTable("Departamentos");

            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Departamento).HasMaxLength(50);
        });

        modelBuilder.Entity<Distribucion>(entity =>
        {
            entity.ToTable("Distribucion");

            entity.Property(e => e.Ajuste)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Almacen)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.CodigoAlmacen)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.CodigoProducto)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Concepto)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Costo)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Costoinicial)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.ExistenciaEnAlmacen)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Fecha).HasDefaultValueSql("('')");
            entity.Property(e => e.FechadeCreacion)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.Fechadeajuste).HasDefaultValueSql("('')");
            entity.Property(e => e.Fechadecompra).HasDefaultValueSql("('')");
            entity.Property(e => e.Fechadevencimiento).HasDefaultValueSql("('')");
            entity.Property(e => e.Inicial)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Stockmaximo)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Stockminimo)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Ultimomovimiento).HasDefaultValueSql("('')");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<Documento>(entity =>
        {
            entity.HasKey(e => e.IdDocumento);

            entity.Property(e => e.Codigo).HasDefaultValue(0);
            entity.Property(e => e.Documento1)
                .HasMaxLength(75)
                .HasDefaultValue("")
                .HasColumnName("Documento");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.Property(e => e.Alias).HasMaxLength(50);
            entity.Property(e => e.Codigo)
                .HasMaxLength(18)
                .IsFixedLength();
            entity.Property(e => e.Nombre).HasMaxLength(70);
        });

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.HasKey(e => e.IdEmpresa).HasName("PK_EMPRESAS");

            entity.Property(e => e.Ambiente)
                .HasMaxLength(2)
                .HasDefaultValue("");
            entity.Property(e => e.Categoria).HasMaxLength(18);
            entity.Property(e => e.Ciudad).HasMaxLength(200);
            entity.Property(e => e.Claveapi)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Claveprivada)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Clavepublica)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Codactividad)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Coddepartamento)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Codigo).HasMaxLength(50);
            entity.Property(e => e.Codmunicipio)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Datos).HasMaxLength(50);
            entity.Property(e => e.Departamento).HasMaxLength(200);
            entity.Property(e => e.Descactividad).HasMaxLength(100);
            entity.Property(e => e.Direccion).HasMaxLength(250);
            entity.Property(e => e.Dui)
                .HasMaxLength(50)
                .HasColumnName("DUI");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Encargadodefacturacion)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Fechadecreacion).HasColumnType("datetime");
            entity.Property(e => e.Giro).HasMaxLength(150);
            entity.Property(e => e.Iva)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("IVA");
            entity.Property(e => e.Linkautenticacion)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.Linkautenticacionproductivo)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.Linkfirma)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.Linkfirmaproductivo)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.Linkrecepcion)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.Linkrecepcionproductivo)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.Logo)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Nit)
                .HasMaxLength(17)
                .HasColumnName("NIT");
            entity.Property(e => e.Nombre).HasMaxLength(250);
            entity.Property(e => e.NombreComercial).HasMaxLength(250);
            entity.Property(e => e.Nombredos)
                .HasMaxLength(70)
                .HasDefaultValue("");
            entity.Property(e => e.Notas).HasMaxLength(250);
            entity.Property(e => e.Nrc)
                .HasMaxLength(10)
                .HasColumnName("NRC");
            entity.Property(e => e.RepresentanteLegal).HasMaxLength(70);
            entity.Property(e => e.Telefono).HasMaxLength(18);
            entity.Property(e => e.Telefono2).HasMaxLength(18);
        });

        modelBuilder.Entity<Entrega>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Entregas_3");

            entity.Property(e => e.Cerrada).HasDefaultValue(false);
            entity.Property(e => e.Cheques).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Despachada).HasDefaultValue(false);
            entity.Property(e => e.Despachadafecha).HasColumnType("datetime");
            entity.Property(e => e.Efectivo).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Fchadecreacion).HasColumnType("datetime");
            entity.Property(e => e.Motorista).HasMaxLength(100);
            entity.Property(e => e.Total).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Totalcobros).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Transferencias).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Usuario).HasMaxLength(50);
            entity.Property(e => e.Zona).HasMaxLength(2);
        });

        modelBuilder.Entity<Entregasdetalle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Entregasdetalles_3");

            entity.Property(e => e.Banco).HasMaxLength(50);
            entity.Property(e => e.Cliente).HasMaxLength(200);
            entity.Property(e => e.Condiciondepago).HasMaxLength(18);
            entity.Property(e => e.Creado).HasColumnType("datetime");
            entity.Property(e => e.Direccion).HasMaxLength(250);
            entity.Property(e => e.Documento).HasMaxLength(50);
            entity.Property(e => e.FormaDePago)
                .HasMaxLength(18)
                .HasColumnName("Forma_de_pago");
            entity.Property(e => e.Keydocumento).HasMaxLength(18);
            entity.Property(e => e.Modificadopor).HasMaxLength(50);
            entity.Property(e => e.Numero).HasMaxLength(50);
            entity.Property(e => e.Observaciones).HasMaxLength(100);
            entity.Property(e => e.Resolucion).HasMaxLength(30);
            entity.Property(e => e.Sucursal).HasMaxLength(60);
            entity.Property(e => e.Tipoabono).HasMaxLength(20);
            entity.Property(e => e.Total).HasColumnType("decimal(18, 9)");
            entity.Property(e => e.Usuario).HasMaxLength(50);
            entity.Property(e => e.Zona).HasMaxLength(50);

            entity.HasOne(d => d.Entrega).WithMany(p => p.Entregasdetalles).HasForeignKey(d => d.EntregaId);
        });

        modelBuilder.Entity<Entregasdetallescobro>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Banco).HasMaxLength(50);
            entity.Property(e => e.Cliente).HasMaxLength(150);
            entity.Property(e => e.Creado).HasColumnType("datetime");
            entity.Property(e => e.Documento).HasMaxLength(18);
            entity.Property(e => e.Fechademodificacion).HasColumnType("datetime");
            entity.Property(e => e.FormaDePago)
                .HasMaxLength(50)
                .HasColumnName("Forma_de_pago");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Keydocumento).HasMaxLength(18);
            entity.Property(e => e.Modificadopor).HasMaxLength(50);
            entity.Property(e => e.Numero).HasMaxLength(50);
            entity.Property(e => e.Observaciones).HasMaxLength(50);
            entity.Property(e => e.Tipoabono).HasMaxLength(20);
            entity.Property(e => e.Total).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Usuario).HasMaxLength(50);
        });

        modelBuilder.Entity<Entregasdetallesnet>(entity =>
        {
            entity.HasKey(e => e.IdEntregaDet).HasName("PK_Entregasdetalles");

            entity.ToTable("Entregasdetallesnet");

            entity.Property(e => e.Banco)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Cancelada).HasDefaultValue(false);
            entity.Property(e => e.Cliente)
                .HasMaxLength(200)
                .HasDefaultValue("");
            entity.Property(e => e.Condiciondepago)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Correlativo).HasDefaultValue(0);
            entity.Property(e => e.Creado)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.Direccion).HasMaxLength(250);
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.FormaDePago)
                .HasMaxLength(18)
                .HasColumnName("Forma_de_pago");
            entity.Property(e => e.Id).HasDefaultValue(0);
            entity.Property(e => e.Keydocumento)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Modificadopor)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Numero)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.Remesaaplicada).HasDefaultValue(false);
            entity.Property(e => e.Resolucion).HasMaxLength(30);
            entity.Property(e => e.Sucursal)
                .HasMaxLength(60)
                .HasDefaultValue("");
            entity.Property(e => e.Tipoabono).HasMaxLength(20);
            entity.Property(e => e.Total)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 9)");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Zona)
                .HasMaxLength(50)
                .HasDefaultValue("");

            entity.HasOne(d => d.IdEntregaNavigation).WithMany(p => p.Entregasdetallesnets)
                .HasForeignKey(d => d.IdEntrega)
                .HasConstraintName("FK_Entregasdetallesnet_Entregasnet");
        });

        modelBuilder.Entity<Entregasdetallesproducto>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Cantidad).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Codigodeproducto).HasMaxLength(18);
            entity.Property(e => e.Creado).HasColumnType("datetime");
            entity.Property(e => e.Descripcion).HasMaxLength(150);
            entity.Property(e => e.Documento).HasMaxLength(18);
            entity.Property(e => e.Factura).HasMaxLength(18);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Proveedor).HasMaxLength(50);
            entity.Property(e => e.Revisado).HasDefaultValue(false);
            entity.Property(e => e.Unidaddemedida).HasMaxLength(50);
            entity.Property(e => e.Usuario).HasMaxLength(50);
        });

        modelBuilder.Entity<Entregasdetallesquedan>(entity =>
        {
            entity.ToTable("Entregasdetallesquedan");

            entity.Property(e => e.Banco)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Cancelada).HasDefaultValue(false);
            entity.Property(e => e.Cliente)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Creado)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.Documento)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.FormaDePago)
                .HasMaxLength(18)
                .HasDefaultValue("")
                .HasColumnName("Forma_de_pago");
            entity.Property(e => e.Keydocumento)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Numero)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Tipoabono)
                .HasMaxLength(20)
                .HasDefaultValue("");
            entity.Property(e => e.Total)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Usuario).HasMaxLength(50);
        });

        modelBuilder.Entity<Entregasnet>(entity =>
        {
            entity.HasKey(e => e.IdEntrega).HasName("PK_Entregas");

            entity.ToTable("Entregasnet");

            entity.Property(e => e.Cerrada).HasDefaultValue(false);
            entity.Property(e => e.Cheques)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Correlativo).HasDefaultValue(0);
            entity.Property(e => e.Despachada).HasDefaultValue(false);
            entity.Property(e => e.Despachadafecha)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.Efectivo)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Fchadecreacion)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.Id).HasDefaultValue(0);
            entity.Property(e => e.Motorista)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.Total)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Totalcobros)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Transferencias).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Zona).HasMaxLength(2);
        });

        modelBuilder.Entity<Eventosdecontingencium>(entity =>
        {
            entity.HasKey(e => e.EventosdecontingenciaId);

            entity.Property(e => e.EventosdecontingenciaId).HasColumnName("EventosdecontingenciaID");
            entity.Property(e => e.Ambiente)
                .HasMaxLength(2)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Codestablemh)
                .HasMaxLength(4)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Codigo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Codigogeneracion)
                .HasMaxLength(36)
                .HasDefaultValue("");
            entity.Property(e => e.Codpuntoventa)
                .HasMaxLength(15)
                .HasDefaultValue("");
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.Ftransmision)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Htransmision)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Json)
                .HasDefaultValue("")
                .HasColumnType("text");
            entity.Property(e => e.Jsonenviado)
                .HasDefaultValue("")
                .HasColumnType("text");
            entity.Property(e => e.Jsonfirmado)
                .HasDefaultValue("")
                .HasColumnType("text");
            entity.Property(e => e.Nit)
                .HasMaxLength(17)
                .HasDefaultValue("")
                .HasColumnName("NIT");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Nombreresponsable)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Numerodocresponsable)
                .HasMaxLength(25)
                .HasDefaultValue("");
            entity.Property(e => e.Procesado).HasDefaultValue(false);
            entity.Property(e => e.Respuesta)
                .HasDefaultValue("")
                .HasColumnType("text");
            entity.Property(e => e.Telefono).HasMaxLength(30);
            entity.Property(e => e.Tipodocresponsable)
                .HasMaxLength(2)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Version)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(2, 0)");
        });

        modelBuilder.Entity<Fisico>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Fisico");

            entity.Property(e => e.Cantidad)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)")
                .HasColumnName("cantidad");
            entity.Property(e => e.Codigodebarra)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("codigodebarra");
            entity.Property(e => e.Codigosistema)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("codigosistema");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .HasDefaultValue("")
                .HasColumnName("descripcion");
            entity.Property(e => e.Fechavencimiento)
                .HasDefaultValueSql("('')")
                .HasColumnName("fechavencimiento");
            entity.Property(e => e.IdFisico).ValueGeneratedOnAdd();
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("lote");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(150)
                .HasDefaultValue("")
                .HasColumnName("ubicacion");
        });

        modelBuilder.Entity<Formasdepago>(entity =>
        {
            entity.ToTable("Formasdepago");

            entity.Property(e => e.Codigo)
                .HasMaxLength(4)
                .HasDefaultValue("");
            entity.Property(e => e.Descripcion).HasMaxLength(50);
            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<GestiondeCobro>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Abono).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Cliente)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.CodigoCliente)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Fecha).HasDefaultValueSql("('')");
            entity.Property(e => e.FechaCreado)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.IdGestion).ValueGeneratedOnAdd();
            entity.Property(e => e.Nota)
                .HasMaxLength(500)
                .HasDefaultValue("");
            entity.Property(e => e.Saldo).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<Grado>(entity =>
        {
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IdGrado)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Id_grado");
            entity.Property(e => e.IdNivel).HasColumnName("Id_nivel");
            entity.Property(e => e.Matricula).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Mensualidad).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Moraporcentaje).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.NombreGrado)
                .HasMaxLength(90)
                .HasColumnName("Nombre_grado");
        });

        modelBuilder.Entity<Invalidacione>(entity =>
        {
            entity.HasKey(e => e.InvalidacionesId);

            entity.Property(e => e.Ambiente)
                .HasMaxLength(2)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Codigo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Codigogeneracion)
                .HasMaxLength(36)
                .HasDefaultValue("");
            entity.Property(e => e.Fecanula)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Horanula)
                .HasMaxLength(8)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Json)
                .HasDefaultValue("")
                .HasColumnType("text");
            entity.Property(e => e.Jsonenviado)
                .HasDefaultValue("")
                .HasColumnType("text");
            entity.Property(e => e.Jsonfirmado)
                .HasDefaultValue("")
                .HasColumnType("text");
            entity.Property(e => e.Procesado).HasDefaultValue(false);
            entity.Property(e => e.Respuesta)
                .HasDefaultValue("")
                .HasColumnType("text");
            entity.Property(e => e.Version)
                .HasDefaultValueSql("('')")
                .HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<Inventario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Inventario_1");

            entity.ToTable("Inventario");

            entity.Property(e => e.Activo).HasDefaultValue(false);
            entity.Property(e => e.Clasificacion)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.Encargado)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.Fecha).HasDefaultValueSql("('')");
            entity.Property(e => e.Filtro)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.Inventario1)
                .HasDefaultValue(0)
                .HasColumnName("Inventario");
            entity.Property(e => e.Tipo)
                .HasMaxLength(100)
                .HasDefaultValue("")
                .HasColumnName("TIpo");
        });

        modelBuilder.Entity<InventarioDetalle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Inventario");

            entity.ToTable("Inventario_Detalle");

            entity.Property(e => e.Categoria)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.CodigoProducto)
                .HasMaxLength(75)
                .HasDefaultValue("");
            entity.Property(e => e.Codigonuevo).HasMaxLength(30);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Diferencia)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.ExistenciaFisica)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.ExistenciaSistema)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.FechadeCreacion)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.Fechavencimientolote).HasDefaultValueSql("('')");
            entity.Property(e => e.Inventario).HasDefaultValue(0);
            entity.Property(e => e.Lote)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.Noestaenproductos)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("noestaenproductos");
            entity.Property(e => e.Observacion)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Perecedero).HasDefaultValue(false);
            entity.Property(e => e.Proveedor)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.Unidaddemedida)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<Lote>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Productoslotes");

            entity.Property(e => e.Cantidad)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Codigodeproducto).HasMaxLength(50);
            entity.Property(e => e.Creado)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.Existencia).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Keydocumento).HasMaxLength(50);
            entity.Property(e => e.Lote1)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("Lote");
            entity.Property(e => e.Seleccionado)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(18)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<Maestra>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Maestra");

            entity.Property(e => e.Clave).HasMaxLength(50);
        });

        modelBuilder.Entity<Matricula>(entity =>
        {
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Nivel).HasMaxLength(50);
            entity.Property(e => e.Valor).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.Property(e => e.Codigo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Submenudos)
                .HasMaxLength(60)
                .HasDefaultValue("");
            entity.Property(e => e.Submenutres)
                .HasMaxLength(60)
                .HasDefaultValue("");
            entity.Property(e => e.Submenuuon)
                .HasMaxLength(60)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<Mesa>(entity =>
        {
            entity.Property(e => e.Abierta).HasDefaultValue(false);
            entity.Property(e => e.Boton)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Codigo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Codigodesalon)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(30)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<Mesero>(entity =>
        {
            entity.Property(e => e.Cargo)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Codigo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Codigodeempleado)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Contraseña)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<Motorista>(entity =>
        {
            entity.Property(e => e.Codigo)
                .HasMaxLength(18)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Suspendido).HasDefaultValue(0);
        });

        modelBuilder.Entity<Movimientosa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Movimientosa_1");

            entity.ToTable("Movimientosa");

            entity.Property(e => e.Actualizada).HasDefaultValue(false);
            entity.Property(e => e.Anuladopor)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Autorizada).HasDefaultValue(false);
            entity.Property(e => e.Codigo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Codigodealmacende)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Codigodealmacenpara)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Codigodedocumento).HasMaxLength(18);
            entity.Property(e => e.Comentarios)
                .HasMaxLength(254)
                .HasDefaultValue("");
            entity.Property(e => e.Correlativo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.De)
                .HasMaxLength(60)
                .HasDefaultValue("");
            entity.Property(e => e.Documento)
                .HasMaxLength(60)
                .HasDefaultValue("");
            entity.Property(e => e.Eliminado).HasDefaultValue(false);
            entity.Property(e => e.Eliminadopor)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Expediente)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Fechadeanulacion)
                .HasDefaultValueSql("((0))")
                .HasColumnType("datetime");
            entity.Property(e => e.Fechadecreacion)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.Fechadeeliminacion)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime");
            entity.Property(e => e.Numero)
                .HasMaxLength(20)
                .HasDefaultValue("");
            entity.Property(e => e.Paciente)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Para)
                .HasMaxLength(60)
                .HasDefaultValue("");
            entity.Property(e => e.Referencia)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Serie)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Total)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.TotalCantidad).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Usuario)
                .HasMaxLength(40)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<MovimientosaDetalle>(entity =>
        {
            entity.HasKey(e => e.IdMovimientosaDet).HasName("PK_Movimientosa_Detalles_1");

            entity.ToTable("Movimientosa_Detalles");

            entity.Property(e => e.IdMovimientosaDet).HasColumnName("IdMovimientosa_det");
            entity.Property(e => e.Almacende)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Almacenpara)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Cantidad)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Categoria)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Codigodealmacen)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Codigodealmacende)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Codigodedocumento)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Codigodeproducto)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Correlativo)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Costo)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Costodeimportacion)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Documento)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.Fechad).HasDefaultValueSql("('')");
            entity.Property(e => e.Item).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Numero)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Precio)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Serie).HasDefaultValue(false);
            entity.Property(e => e.Tiempodecredito)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Total)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Valor)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
        });

        modelBuilder.Entity<Municipio>(entity =>
        {
            entity.ToTable("Municipio");

            entity.Property(e => e.MunicipioId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Municipio_Id");
            entity.Property(e => e.DepartamentoId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Departamento_Id");
            entity.Property(e => e.Municipio1)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("Municipio");

            entity.HasOne(d => d.Departamento).WithMany(p => p.Municipios)
                .HasForeignKey(d => d.DepartamentoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Municipi_Departame_Departam");
        });

        modelBuilder.Entity<Municipio1>(entity =>
        {
            entity.HasKey(e => e.MunicipiosId);

            entity.ToTable("Municipios");

            entity.Property(e => e.CodDepartamento)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<Ordene>(entity =>
        {
            entity.Property(e => e.Cantidadsegunformula)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Fechadecreacion)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.Numero).HasMaxLength(18);
            entity.Property(e => e.Solicitadapor).HasMaxLength(90);
            entity.Property(e => e.Usuario).HasMaxLength(50);
        });

        modelBuilder.Entity<OrdenesDetalle>(entity =>
        {
            entity.ToTable("Ordenes_detalles");

            entity.Property(e => e.Cantidad).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Codigodeproducto)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Fechadecreacion)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.Idorden).HasDefaultValue(0);
            entity.Property(e => e.Producto)
                .HasMaxLength(90)
                .HasDefaultValue("");
            entity.Property(e => e.Usuario).HasMaxLength(50);
        });

        modelBuilder.Entity<Paise>(entity =>
        {
            entity.HasKey(e => e.PaisId);

            entity.Property(e => e.Codigo)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.Nombre)
                .HasMaxLength(250)
                .IsFixedLength();
        });

        modelBuilder.Entity<ParametrosContabilidad>(entity =>
        {
            entity.HasKey(e => e.IdParametros).HasName("PK_PARAMETROSCONTABILIDAD");

            entity.ToTable("ParametrosContabilidad");

            entity.Property(e => e.Clasificacion).HasMaxLength(200);
            entity.Property(e => e.Cotrans).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Datos).HasMaxLength(250);
            entity.Property(e => e.Fechadecreacion).HasColumnType("datetime");
            entity.Property(e => e.IsRenta).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Iva)
                .HasColumnType("numeric(18, 9)")
                .HasColumnName("IVA");
            entity.Property(e => e.Mes).HasMaxLength(150);
            entity.Property(e => e.NivelCinco).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.NivelCuatro).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.NivelDos).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.NivelSeis).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.NivelSiete).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.NivelUno).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Niveltres).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.PagoaCuenta).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Percepcion).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Renta).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.ReservaLegal).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Retencion).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Tipo).HasMaxLength(200);
            entity.Property(e => e.UnidadoRecursoCompartido).HasMaxLength(150);
        });

        modelBuilder.Entity<Periodo>(entity =>
        {
            entity.HasKey(e => e.IdPeriodo);

            entity.Property(e => e.Año).HasMaxLength(50);
            entity.Property(e => e.Codigo).HasMaxLength(50);
            entity.Property(e => e.CodigodeEmpresa).HasMaxLength(50);
            entity.Property(e => e.Datos).HasMaxLength(250);
            entity.Property(e => e.Descripcion).HasMaxLength(250);
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.KeyId).HasMaxLength(50);
            entity.Property(e => e.Mes).HasMaxLength(50);
            entity.Property(e => e.NumerodeMes).HasMaxLength(50);
            entity.Property(e => e.RaizdeDatos).HasMaxLength(250);
            entity.Property(e => e.UsuarioCreado).HasMaxLength(50);
        });

        modelBuilder.Entity<Precio>(entity =>
        {
            entity.Property(e => e.Codigoanterior).HasMaxLength(30);
            entity.Property(e => e.Codigodeproducto)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Codigonuevo).HasMaxLength(30);
            entity.Property(e => e.Creado)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.Descripcionpresentacion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Factor)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Precio1)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)")
                .HasColumnName("Precio");
            entity.Property(e => e.Presentacion)
                .HasMaxLength(25)
                .HasDefaultValue("");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.ProductoId).HasName("PK_prod");

            entity.Property(e => e.Categoria)
                .HasMaxLength(90)
                .HasDefaultValue("");
            entity.Property(e => e.CodInstitucion)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Codigodebarras)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Costo)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.CostoPromedio)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Costoconimpuesto)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Costofob)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Costoinicial)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Cuenta)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.Descripciondos).HasMaxLength(150);
            entity.Property(e => e.Eiminadopor)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Eliminado).HasDefaultValue(false);
            entity.Property(e => e.Exento).HasColumnName("exento");
            entity.Property(e => e.Existencia)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.ExistenciaAnterior)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Existenciados)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Existenciageneral)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Existenciainicia)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Existenciainiciacuatro)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Existenciainiciados)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Existenciainicial)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Existenciainiciatres)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Existenciatres)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Fechadecreacion)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.Fechadeeliminacion)
                .HasDefaultValueSql("((0))")
                .HasColumnType("datetime");
            entity.Property(e => e.Fisicosucdos)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Fisicosuctres)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Fisicosucuno)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Imagen1)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Imagen2)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Imagen3)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Imagen4)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Marca)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Noaplicadescuento).HasDefaultValue(false);
            entity.Property(e => e.Notas)
                .HasMaxLength(200)
                .HasDefaultValue("");
            entity.Property(e => e.Oem)
                .HasMaxLength(60)
                .HasDefaultValue("");
            entity.Property(e => e.Preciodos)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)")
                .HasColumnName("preciodos");
            entity.Property(e => e.Preciotres)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)")
                .HasColumnName("preciotres");
            entity.Property(e => e.Preciouno)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)")
                .HasColumnName("preciouno");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.Proveedorsecundario)
                .HasMaxLength(254)
                .HasDefaultValue("");
            entity.Property(e => e.Servicio).HasDefaultValue(false);
            entity.Property(e => e.Stockmaximo)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Stockminimo)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Subcategoria).HasMaxLength(50);
            entity.Property(e => e.Suspendido).HasDefaultValue(false);
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(75)
                .HasDefaultValue("");
            entity.Property(e => e.Ultimocosto)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Unidaddemedida)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Utilidaddos)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Utilidadtres)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Utilidaduno)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
        });

        modelBuilder.Entity<ProductosSeleccionado>(entity =>
        {
            entity.HasKey(e => e.SeleccionadoId);

            entity.Property(e => e.CantidadSeleccionada)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Creado)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExistenciaLote)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.KeyVenta)
                .HasMaxLength(75)
                .HasDefaultValue("");
            entity.Property(e => e.LoteId).HasColumnName("LoteID");
            entity.Property(e => e.SeleccionadoLote)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Usuario)
                .HasMaxLength(150)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<ProductosUbicacione>(entity =>
        {
            entity.HasKey(e => e.IdUbicacionproducto);

            entity.Property(e => e.Codigodeproducto)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Creado)
                .HasMaxLength(50)
                .HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<Proveedore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Proveedores_1");

            entity.Property(e => e.Banco)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Cargo)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("ciudad");
            entity.Property(e => e.Clasifi)
                .HasMaxLength(1)
                .HasDefaultValue("")
                .HasColumnName("clasifi");
            entity.Property(e => e.Codempresa)
                .HasMaxLength(1)
                .HasDefaultValue("");
            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Contacto)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("contacto");
            entity.Property(e => e.Contrib).HasColumnName("contrib");
            entity.Property(e => e.Ctaabo)
                .HasMaxLength(1)
                .HasDefaultValue("")
                .HasColumnName("CTAABO");
            entity.Property(e => e.Ctacar)
                .HasMaxLength(1)
                .HasDefaultValue("")
                .HasColumnName("CTACAR");
            entity.Property(e => e.Cuenta)
                .HasMaxLength(18)
                .HasDefaultValue("")
                .HasColumnName("CUENTA");
            entity.Property(e => e.Cuentabancaria)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Declaiva).HasColumnName("DECLAIVA");
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Descuento)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)")
                .HasColumnName("descuento");
            entity.Property(e => e.Diasdecredito).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Direccion)
                .HasMaxLength(150)
                .HasDefaultValue("")
                .HasColumnName("direccion");
            entity.Property(e => e.Dui)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("dui");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Exento).HasColumnName("EXENTO");
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("fax");
            entity.Property(e => e.Fechadecreacion)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.Giro)
                .HasMaxLength(100)
                .HasDefaultValue("")
                .HasColumnName("giro");
            entity.Property(e => e.LimiteCre)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)")
                .HasColumnName("limite_cre");
            entity.Property(e => e.LocExt).HasColumnName("LOC_EXT");
            entity.Property(e => e.Nit)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("NIT");
            entity.Property(e => e.NoRegistro)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("No_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasDefaultValue("")
                .HasColumnName("nombre");
            entity.Property(e => e.Nombre2)
                .HasMaxLength(100)
                .HasDefaultValue("")
                .HasColumnName("nombre2");
            entity.Property(e => e.Pagoelectronico).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Pais)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("pais");
            entity.Property(e => e.Puesto)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("puesto");
            entity.Property(e => e.Saldo)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)")
                .HasColumnName("saldo");
            entity.Property(e => e.Telefono1)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("telefono1");
            entity.Property(e => e.Telefono2)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("telefono2");
            entity.Property(e => e.Tipo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.TipoCli)
                .HasDefaultValueSql("('')")
                .HasColumnName("TIPO_CLI");
            entity.Property(e => e.TipoCuenta)
                .HasMaxLength(25)
                .HasDefaultValue("")
                .HasColumnName("Tipo_Cuenta");
            entity.Property(e => e.TipoProveedor)
                .HasMaxLength(1)
                .HasDefaultValue("")
                .HasColumnName("Tipo_Proveedor");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Web)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("WEB");
        });

        modelBuilder.Entity<Quedan>(entity =>
        {
            entity.ToTable("Quedan");

            entity.Property(e => e.Almacen)
                .HasMaxLength(60)
                .HasDefaultValue("");
            entity.Property(e => e.Cancelado).HasDefaultValue(true);
            entity.Property(e => e.Codigodealmacen)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Codigodeproveedor)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Codigokey)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Cuenta)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Cuentadebanco)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Cuota)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.De)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(80)
                .HasDefaultValue("");
            entity.Property(e => e.Diayhoradepago)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime");
            entity.Property(e => e.Documentono)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Fecha).HasDefaultValueSql("('')");
            entity.Property(e => e.Fechadecancelacion).HasDefaultValueSql("('')");
            entity.Property(e => e.Fechadepago).HasDefaultValueSql("('')");
            entity.Property(e => e.Fechadocumento).HasDefaultValueSql("('')");
            entity.Property(e => e.Horaa)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Horade)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Letras)
                .HasMaxLength(90)
                .HasDefaultValue("");
            entity.Property(e => e.Lugaryfecha)
                .HasMaxLength(70)
                .HasDefaultValue("");
            entity.Property(e => e.Nit)
                .HasMaxLength(21)
                .HasDefaultValue("");
            entity.Property(e => e.Notas)
                .HasMaxLength(254)
                .HasDefaultValue("");
            entity.Property(e => e.Nrc)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Numero)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Numerodecuotas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Quedan1)
                .HasMaxLength(18)
                .HasDefaultValue("")
                .HasColumnName("Quedan");
            entity.Property(e => e.Total)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Valor)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
        });

        modelBuilder.Entity<Quedandetalle>(entity =>
        {
            entity.Property(e => e.Codigokey)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Cuenta)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(90)
                .HasDefaultValue("");
            entity.Property(e => e.Factura).HasMaxLength(18);
            entity.Property(e => e.Fecha).HasDefaultValueSql("('')");
            entity.Property(e => e.Numero)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Valor)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
        });

        modelBuilder.Entity<Rechazado>(entity =>
        {
            entity.Property(e => e.Creado)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.Respuesta)
                .HasDefaultValue("")
                .HasColumnType("text");
        });

        modelBuilder.Entity<Reinicio>(entity =>
        {
            entity.HasKey(e => e.ReiniciosId);

            entity.Property(e => e.Reyear).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<Reporte>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Descripcion)
                .HasMaxLength(75)
                .HasDefaultValue("");
            entity.Property(e => e.IdReporte).ValueGeneratedOnAdd();
            entity.Property(e => e.Modulo)
                .HasMaxLength(75)
                .HasDefaultValue("");
            entity.Property(e => e.Nombre)
                .HasMaxLength(75)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<Salida>(entity =>
        {
            entity.HasKey(e => e.VentaId);

            entity.Property(e => e.Abono)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Actualizada).HasDefaultValue(true);
            entity.Property(e => e.Almacencodigo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Anuladopor)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Aplicaretencion).HasDefaultValue(true);
            entity.Property(e => e.Aplicarpercepcion).HasDefaultValue(true);
            entity.Property(e => e.Autorizadopor)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Banco)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Bitcoin).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Caja)
                .HasMaxLength(10)
                .HasDefaultValue("");
            entity.Property(e => e.Cambio)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Cancelada).HasDefaultValue(false);
            entity.Property(e => e.Categoria)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Categoriadeventa)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Chequenumero)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Clasificasion)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Cliente)
                .HasMaxLength(120)
                .HasDefaultValue("");
            entity.Property(e => e.Clientecodigo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Codigo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.CodigoVendedor)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Comentario)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Concepto)
                .HasMaxLength(90)
                .HasDefaultValue("");
            entity.Property(e => e.Correlativo)
                .HasMaxLength(10)
                .HasDefaultValue("");
            entity.Property(e => e.Correlativohasta)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Departamento)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Descuento)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Diasdecredito)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Documento)
                .HasMaxLength(60)
                .HasDefaultValue("");
            entity.Property(e => e.Documentoactivo).HasDefaultValue(false);
            entity.Property(e => e.Documentocodigo)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Dui)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Efectivo)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Eliminado).HasDefaultValue(false);
            entity.Property(e => e.Eliminadopor)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Exentas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Exportaciones)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Exportacionesfuera)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Exportacionesregion)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Fecha).HasDefaultValueSql("('')");
            entity.Property(e => e.FechaReferencia).HasDefaultValueSql("('')");
            entity.Property(e => e.FechadeAutorizacion).HasDefaultValueSql("('')");
            entity.Property(e => e.Fechadeanulacion)
                .HasDefaultValueSql("((0))")
                .HasColumnType("datetime");
            entity.Property(e => e.Fechadecancelacion).HasDefaultValueSql("('')");
            entity.Property(e => e.Fechadecancelado)
                .HasDefaultValueSql("((0))")
                .HasColumnType("datetime");
            entity.Property(e => e.Fechadecreacion)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.Fechadeeliminacion)
                .HasDefaultValueSql("((0))")
                .HasColumnType("datetime");
            entity.Property(e => e.Fechadevencimiento).HasDefaultValueSql("('')");
            entity.Property(e => e.FormaDePago)
                .HasMaxLength(30)
                .HasDefaultValue("")
                .HasColumnName("Forma_de_pago");
            entity.Property(e => e.Fovial)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Giro)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Gravadas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Gravadasaconsumidores)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Gravadasconsumidores)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Iva)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Ivapercibido)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Ivaretenido)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Nit)
                .HasMaxLength(25)
                .HasDefaultValue("");
            entity.Property(e => e.NoRegistro)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("No_registro");
            entity.Property(e => e.Notaderemision)
                .HasMaxLength(4)
                .HasDefaultValue("");
            entity.Property(e => e.Notas)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Numero)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.NumerodeResolucion)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.NumerodeSerie)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Referencia)
                .HasMaxLength(18)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.Remesa)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Retencion).HasDefaultValue(true);
            entity.Property(e => e.Saldo)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Saldo30)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Saldo60)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Saldo90)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Saldo90ymas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Saldodelafactura)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Seleccionada).HasDefaultValue(false);
            entity.Property(e => e.Subtotal)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Sucursal)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Sumas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Tarjeta)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Tarjetadv).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Tarjetatv)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Tarjetauv).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Telefono)
                .HasMaxLength(25)
                .HasDefaultValue("");
            entity.Property(e => e.Telefono2)
                .HasMaxLength(25)
                .HasDefaultValue("");
            entity.Property(e => e.Telefonocheque)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Total)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Transferencia)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Usuario)
                .HasMaxLength(40)
                .HasDefaultValue("");
            entity.Property(e => e.Valor)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.ValorNeto)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)")
                .HasColumnName("Valor_neto");
            entity.Property(e => e.Valordeldescuento)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Valorretencion)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Vcontado)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Vcredito)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Vendedor)
                .HasMaxLength(60)
                .HasDefaultValue("");
            entity.Property(e => e.VentaTotal)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)")
                .HasColumnName("Venta_total");
            entity.Property(e => e.Ventaexenta)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Ventasiniva)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Vetasexentas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Zonasydpa)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
        });

        modelBuilder.Entity<SalidasDetalle>(entity =>
        {
            entity.HasKey(e => e.VentaDetalleId);

            entity.ToTable("Salidas_detalles");

            entity.Property(e => e.Almacenalias)
                .HasMaxLength(40)
                .HasDefaultValue("");
            entity.Property(e => e.Almacencodigo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Barra)
                .HasMaxLength(60)
                .HasDefaultValue("");
            entity.Property(e => e.Cantidad)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Categoria)
                .HasMaxLength(90)
                .HasDefaultValue("");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasDefaultValue("");
            entity.Property(e => e.Correlativo)
                .HasMaxLength(10)
                .HasDefaultValue("");
            entity.Property(e => e.Costo)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Costodeimportacion)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Descuento)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Documentocodigo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Facturacion)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Facturaoccf)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Fechadecreacion)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.Item)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Margen)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Nombre)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Nosujetas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Notaderemision)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.PorcentajeGanancia)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.PrecioConIva)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)")
                .HasColumnName("Precio_con_iva");
            entity.Property(e => e.PrecioFacturado)
                .HasMaxLength(75)
                .HasDefaultValue("");
            entity.Property(e => e.PrecioUni)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)")
                .HasColumnName("Precio_uni");
            entity.Property(e => e.Preciosiniva)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Productocodigo)
                .HasMaxLength(75)
                .HasDefaultValue("");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(200)
                .HasDefaultValue("");
            entity.Property(e => e.Referencia)
                .HasMaxLength(40)
                .HasDefaultValue("");
            entity.Property(e => e.SalidaId).HasDefaultValue(0);
            entity.Property(e => e.Serie).HasDefaultValue(true);
            entity.Property(e => e.Servicio).HasDefaultValue(true);
            entity.Property(e => e.Subtotal)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Unidaddemedida)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.ValorGanancia)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Ventaexenta)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Ventasafectas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Ventasexenta)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");

            entity.HasOne(d => d.Salida).WithMany(p => p.SalidasDetalles)
                .HasForeignKey(d => d.SalidaId)
                .HasConstraintName("FK_Salidas_detalles_Salidas");

            entity.HasOne(d => d.SalidaNavigation).WithMany(p => p.SalidasDetalles)
                .HasForeignKey(d => d.SalidaId)
                .HasConstraintName("FK_Salidas_detalles_Ventas");
        });

        modelBuilder.Entity<Salone>(entity =>
        {
            entity.Property(e => e.Codigo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<Subcategorium>(entity =>
        {
            entity.Property(e => e.Categoria).HasMaxLength(50);
            entity.Property(e => e.Codigo).HasMaxLength(18);
            entity.Property(e => e.Codigodecategoria)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Usuario).HasMaxLength(50);
        });

        modelBuilder.Entity<Submenu>(entity =>
        {
            entity.Property(e => e.Codigo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Menuprincipal)
                .HasMaxLength(60)
                .HasDefaultValue("");
            entity.Property(e => e.Submenu1)
                .HasMaxLength(60)
                .HasDefaultValue("")
                .HasColumnName("Submenu");
            entity.Property(e => e.Subsub)
                .HasMaxLength(10)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<Subsubmenu>(entity =>
        {
            entity.Property(e => e.Codigo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Menu)
                .HasMaxLength(60)
                .HasDefaultValue("");
            entity.Property(e => e.Menuprincipal)
                .HasMaxLength(60)
                .HasDefaultValue("");
            entity.Property(e => e.Submenu)
                .HasMaxLength(60)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<Sucursalescliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Sucursal");

            entity.Property(e => e.Ciudad)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Codigodecliente)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Codigodesucursal)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Departamento)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Fechadecreacion)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.Geolocalizacion)
                .HasMaxLength(500)
                .HasDefaultValue("");
            entity.Property(e => e.Nombre)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Sucursal)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Telefono)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Zona)
                .HasMaxLength(2)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<Supervisore>(entity =>
        {
            entity.Property(e => e.Codigo)
                .HasMaxLength(18)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<Titulosbiene>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Codigo)
                .HasMaxLength(2)
                .HasDefaultValue("");
            entity.Property(e => e.IdTitulobienes).ValueGeneratedOnAdd();
            entity.Property(e => e.Valores)
                .HasMaxLength(20)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<Token>(entity =>
        {
            entity.HasKey(e => e.Numero);

            entity.Property(e => e.Codigo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Creado)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.Token1)
                .HasDefaultValue("")
                .HasColumnType("text")
                .HasColumnName("Token");
            entity.Property(e => e.Usuario).HasMaxLength(50);
        });

        modelBuilder.Entity<Ubicacione>(entity =>
        {
            entity.HasKey(e => e.IdUbicacion);

            entity.Property(e => e.Creado)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Fechamodificacion).HasColumnType("datetime");
            entity.Property(e => e.Modificadopor)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .HasDefaultValue("");
            entity.Property(e => e.Usuario).HasMaxLength(50);
        });

        modelBuilder.Entity<Unidadesdemedida>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_unidadesdemedidas");

            entity.Property(e => e.Categoriaprincipal).HasMaxLength(50);
            entity.Property(e => e.Codigo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<Utilidade>(entity =>
        {
            entity.HasKey(e => e.UtilidadesId);

            entity.Property(e => e.Descripcion)
                .HasMaxLength(120)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<Venta>(entity =>
        {
            entity.Property(e => e.Abono)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Actualizada).HasDefaultValue(true);
            entity.Property(e => e.Almacencodigo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Ambiente)
                .HasMaxLength(2)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Anuladopor)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Aplicarenta).HasDefaultValue(false);
            entity.Property(e => e.Aplicaretencion).HasDefaultValue(true);
            entity.Property(e => e.Aplicarpercepcion).HasDefaultValue(true);
            entity.Property(e => e.Autorizadopor)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Banco)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Bitcoin).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Caja)
                .HasMaxLength(10)
                .HasDefaultValue("");
            entity.Property(e => e.Cambio)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Cancelada).HasDefaultValue(false);
            entity.Property(e => e.Categoriadeventa)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Chequenumero)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Clasificacion)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Clasificasion)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Cliente)
                .HasMaxLength(120)
                .HasDefaultValue("");
            entity.Property(e => e.Clientecodigo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Clienteexento).HasDefaultValue(false);
            entity.Property(e => e.CodActividad)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.CodDepartamento)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.CodMunicipio)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Codigo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.CodigoGeneracion)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.CodigoVendedor)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Codpais)
                .HasMaxLength(10)
                .HasDefaultValue("");
            entity.Property(e => e.Comentario)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Concepto)
                .HasMaxLength(90)
                .HasDefaultValue("");
            entity.Property(e => e.Condiciondepago)
                .HasMaxLength(70)
                .HasDefaultValue("");
            entity.Property(e => e.Correlativo)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.Correlativohasta)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Correoenviado).HasDefaultValue(false);
            entity.Property(e => e.Creado)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.DepInst)
                .HasMaxLength(30)
                .HasDefaultValue("")
                .HasColumnName("Dep_inst");
            entity.Property(e => e.Departamento)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Descactividad)
                .HasMaxLength(200)
                .HasDefaultValue("");
            entity.Property(e => e.Descuento)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Diasdecredito)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.DirInst)
                .HasMaxLength(150)
                .HasDefaultValue("")
                .HasColumnName("Dir_inst");
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Documento)
                .HasMaxLength(60)
                .HasDefaultValue("");
            entity.Property(e => e.Documentoactivo).HasDefaultValue(false);
            entity.Property(e => e.Documentocodigo)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Documentoencargado)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Documentoentregado)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Documentorecibidopor)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Dui)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Efectivo)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Eliminado).HasDefaultValue(false);
            entity.Property(e => e.Eliminadopor)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.EmaInst)
                .HasMaxLength(90)
                .HasDefaultValue("")
                .HasColumnName("Ema_inst");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Encargadodeentrega)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.EstadoComision)
                .HasMaxLength(9)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Exentas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Exportaciones)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Exportacionesfuera)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Exportacionesregion)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Fecha).HasDefaultValueSql("('')");
            entity.Property(e => e.FechaReferencia).HasDefaultValueSql("('')");
            entity.Property(e => e.FechadeAutorizacion).HasDefaultValueSql("('')");
            entity.Property(e => e.Fechadeanulacion)
                .HasDefaultValueSql("((0))")
                .HasColumnType("datetime");
            entity.Property(e => e.Fechadecancelacion).HasDefaultValueSql("('')");
            entity.Property(e => e.Fechadecancelado)
                .HasDefaultValueSql("((0))")
                .HasColumnType("datetime");
            entity.Property(e => e.Fechadecreacion)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.Fechadeeliminacion)
                .HasDefaultValueSql("((0))")
                .HasColumnType("datetime");
            entity.Property(e => e.Fechadeprocesado).HasColumnType("datetime");
            entity.Property(e => e.Fechadevencimiento).HasDefaultValueSql("('')");
            entity.Property(e => e.Fechaprocesado).HasColumnType("datetime");
            entity.Property(e => e.FormaDePago)
                .HasMaxLength(30)
                .HasDefaultValue("")
                .HasColumnName("Forma_de_pago");
            entity.Property(e => e.Formadepago)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("formadepago");
            entity.Property(e => e.Fovial)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Gestionado)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Giro)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Gravadas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Gravadasaconsumidores)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Gravadasconsumidores)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Hora)
                .HasMaxLength(20)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Invalidado).HasDefaultValue(false);
            entity.Property(e => e.Iva)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Ivapercibido)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Ivaretenido)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Json)
                .HasDefaultValue("")
                .HasColumnType("text");
            entity.Property(e => e.Jsoncliente)
                .HasDefaultValue("")
                .HasColumnType("text");
            entity.Property(e => e.Jsonenviado)
                .HasDefaultValue("")
                .HasColumnType("text");
            entity.Property(e => e.Jsonfirmado)
                .HasDefaultValue("")
                .HasColumnType("text");
            entity.Property(e => e.Modelodefacturacion)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Modocontingencia).HasDefaultValue(0);
            entity.Property(e => e.MunInst)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("Mun_inst");
            entity.Property(e => e.Nit)
                .HasMaxLength(25)
                .HasDefaultValue("");
            entity.Property(e => e.NoRegistro)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("No_registro");
            entity.Property(e => e.NombreComercial)
                .HasMaxLength(200)
                .HasDefaultValue("");
            entity.Property(e => e.Nosujetas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Notaderemision)
                .HasMaxLength(4)
                .HasDefaultValue("");
            entity.Property(e => e.Notas)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Notasdos)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Numero)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.NumerodeResolucion)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.NumerodeSerie)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Numerodecontrol)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.Pais)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Procesado).HasDefaultValue(false);
            entity.Property(e => e.Recibidopor)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.Recinto)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Referencia)
                .HasMaxLength(100)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.Regimen)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Remesa)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Renta)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Respuesta)
                .HasDefaultValue("")
                .HasColumnType("text");
            entity.Property(e => e.Retencion).HasDefaultValue(true);
            entity.Property(e => e.Saldo)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Saldo30)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Saldo60)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Saldo90)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Saldo90ymas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Saldodelafactura)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Seleccionada).HasDefaultValue(false);
            entity.Property(e => e.Selloderecibido)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.Serienumero)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.Subtotal)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Sucursal)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Sujetodepercepcion).HasDefaultValue(false);
            entity.Property(e => e.Sumas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Tarjeta)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Tarjetadv).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Tarjetatv)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Tarjetauv).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.TelInst)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("Tel_inst");
            entity.Property(e => e.Telefono)
                .HasMaxLength(25)
                .HasDefaultValue("");
            entity.Property(e => e.Telefono2)
                .HasMaxLength(25)
                .HasDefaultValue("");
            entity.Property(e => e.Telefonocheque)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Tipodeingreso).HasMaxLength(90);
            entity.Property(e => e.Tipodeoperacion).HasMaxLength(90);
            entity.Property(e => e.Tipotransmision)
                .HasMaxLength(10)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Titulo)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Token)
                .HasDefaultValue("")
                .HasColumnType("text");
            entity.Property(e => e.Total)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Transferencia)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Usuario)
                .HasMaxLength(40)
                .HasDefaultValue("");
            entity.Property(e => e.Valor)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.ValorNeto)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)")
                .HasColumnName("Valor_neto");
            entity.Property(e => e.Valordeldescuento)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Valorretencion)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Vcontado)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Vcredito)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Vendedor)
                .HasMaxLength(60)
                .HasDefaultValue("");
            entity.Property(e => e.VentaTotal)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)")
                .HasColumnName("Venta_total");
            entity.Property(e => e.Ventaexenta)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Ventasiniva)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Vetasexentas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Zonasydpa)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
        });

        modelBuilder.Entity<VentasDetalle>(entity =>
        {
            entity.HasKey(e => e.VentaDetalleId);

            entity.ToTable("Ventas_detalles");

            entity.Property(e => e.Almacenalias)
                .HasMaxLength(40)
                .HasDefaultValue("");
            entity.Property(e => e.Almacencodigo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Barra)
                .HasMaxLength(60)
                .HasDefaultValue("");
            entity.Property(e => e.Cantidad)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Categoria)
                .HasMaxLength(90)
                .HasDefaultValue("");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasDefaultValue("");
            entity.Property(e => e.Comision)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Correlativo)
                .HasMaxLength(10)
                .HasDefaultValue("");
            entity.Property(e => e.Costo)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Costodeimportacion)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Descuento)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Documentocodigo)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Facturacion)
                .HasMaxLength(18)
                .HasDefaultValue("");
            entity.Property(e => e.Facturaoccf)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Fechadecreacion)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime");
            entity.Property(e => e.Fechahoracambioprecio).HasColumnName("fechahoracambioprecio");
            entity.Property(e => e.Item)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Justificacion).HasMaxLength(254);
            entity.Property(e => e.Margen)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Nombre)
                .HasMaxLength(250)
                .HasDefaultValue("");
            entity.Property(e => e.Nosujetas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Notaderemision)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.PorcentajeGanancia)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.PrecioConIva)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)")
                .HasColumnName("Precio_con_iva");
            entity.Property(e => e.PrecioFacturado)
                .HasMaxLength(75)
                .HasDefaultValue("");
            entity.Property(e => e.PrecioUni)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)")
                .HasColumnName("Precio_uni");
            entity.Property(e => e.Preciosindescuento).HasColumnType("decimal(18, 9)");
            entity.Property(e => e.Preciosiniva)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Productocodigo)
                .HasMaxLength(75)
                .HasDefaultValue("");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(200)
                .HasDefaultValue("");
            entity.Property(e => e.Referencia)
                .HasMaxLength(40)
                .HasDefaultValue("");
            entity.Property(e => e.Serie).HasDefaultValue(true);
            entity.Property(e => e.Servicio).HasDefaultValue(true);
            entity.Property(e => e.Subtotal)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Text1).HasDefaultValue("");
            entity.Property(e => e.Text2).HasDefaultValue("");
            entity.Property(e => e.Unidaddemedida)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Usuariocambioprecio).HasMaxLength(50);
            entity.Property(e => e.ValorGanancia)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Valorcomision)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 9)");
            entity.Property(e => e.VentaId).HasDefaultValue(0);
            entity.Property(e => e.Ventaexenta)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Ventasafectas)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
            entity.Property(e => e.Ventasexenta)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 9)");
        });

        modelBuilder.Entity<Zona>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

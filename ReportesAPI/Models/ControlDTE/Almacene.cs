using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Almacene
{
    public int Id { get; set; }

    public DateTime? Fechadecreacion { get; set; }

    public string? Usuario { get; set; }

    public string? Codigo { get; set; }

    public string? Nombre { get; set; }

    public string? Direccion { get; set; }

    public string? Ciudad { get; set; }

    public string? Departamento { get; set; }

    public string? Telefono1 { get; set; }

    public string? Telefono2 { get; set; }

    public string? Representante { get; set; }

    public bool? Salidasparaventa { get; set; }

    public string? Alias { get; set; }

    public decimal? Numerodecuentas { get; set; }

    public decimal? Cuentascanceladas { get; set; }

    public decimal? Cuentasactivas { get; set; }

    public decimal? Cuentasdecomisadas { get; set; }

    public bool? Noreportes { get; set; }

    public decimal? Cuentasnuevas { get; set; }

    public decimal? Cuentasquepagaron { get; set; }

    public decimal? Cuentasquenopagaron { get; set; }

    public decimal? Tcontado { get; set; }

    public decimal? Tcredito { get; set; }

    public decimal? Tcompras { get; set; }

    public string? Factor { get; set; }

    public string? Ingresosporventacontado { get; set; }

    public string? Ingresosporventacredito { get; set; }

    public string? Ivadebitofiscalccf { get; set; }

    public string? Ivadebitofiscalfac { get; set; }

    public string? Fovialventas { get; set; }

    public string? Ventasccf { get; set; }

    public string? Ventasfac { get; set; }

    public string? Ventasdeexportacion { get; set; }

    public string? Ivacompras { get; set; }

    public string? Fovialcompras { get; set; }

    public string? Pagosenefectivo { get; set; }

    public string? Provisioncompras { get; set; }

    public bool? Actualizado { get; set; }

    public string? Comprasdeinventario { get; set; }

    public string? Percepcioncompras { get; set; }

    public string? Percepcionventas { get; set; }

    public string? Ultimoccf { get; set; }

    public string? Ultimofac { get; set; }

    public string? Ultimontd { get; set; }

    public string? Ultimonta { get; set; }

    public string? Ultimofacexp { get; set; }

    public string? Ultimofacsim { get; set; }

    public string? Ultimontretencion { get; set; }

    public string? Ultimontc { get; set; }

    public string? Partidaacumulada { get; set; }

    public string? Cotrans { get; set; }

    public string? Retencioncompras { get; set; }

    public string? Rebajasydevolucionesventas { get; set; }

    public string? Rebajasydevolucionescompras { get; set; }

    public string? Regaliasventascargo { get; set; }

    public string? Ventasnetasccfcredito { get; set; }

    public string? Ventasnetasfaccredito { get; set; }

    public string? Afdebito { get; set; }

    public string? Regaliasventasabono { get; set; }

    public string? Ventasexentas { get; set; }

    public string? Comprasexentas { get; set; }

    public string? Retencionventas { get; set; }

    public string? Correlativoderemesas { get; set; }

    public bool? Comprascentralizadas { get; set; }

    public string? Cuentagasto { get; set; }

    public string? Abonosacontratos { get; set; }

    public string? Costodeventadepreciacioncargo { get; set; }

    public string? Costodeventadepreciacionabono { get; set; }

    public string? Creditosfacabono { get; set; }

    public string? Creditosccfabono { get; set; }

    public bool? Ventasconcontrato { get; set; }

    public string? Cuentadeingresos { get; set; }

    public string? Cuentadegastos { get; set; }

    public string? Cuentadecostos { get; set; }

    public string? Bienesenarrendamiento { get; set; }

    public string? Creditosfac { get; set; }

    public string? Creditosccf { get; set; }

    public bool? Predeterminado { get; set; }
}

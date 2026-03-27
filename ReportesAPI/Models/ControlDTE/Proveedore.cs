using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Proveedore
{
    public int Id { get; set; }

    public DateTime Fechadecreacion { get; set; }

    public string Usuario { get; set; } = null!;

    public string Codigo { get; set; } = null!;

    public string Codempresa { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Nombre2 { get; set; } = null!;

    public string Contacto { get; set; } = null!;

    public string Puesto { get; set; } = null!;

    public string Telefono1 { get; set; } = null!;

    public string Telefono2 { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Web { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Pais { get; set; } = null!;

    public string Departamento { get; set; } = null!;

    public string Ciudad { get; set; } = null!;

    public byte TipoCli { get; set; }

    public bool Contrib { get; set; }

    public bool Exento { get; set; }

    public bool Declaiva { get; set; }

    public string NoRegistro { get; set; } = null!;

    public string Giro { get; set; } = null!;

    public string Nit { get; set; } = null!;

    public string Clasifi { get; set; } = null!;

    public bool LocExt { get; set; }

    public string Ctaabo { get; set; } = null!;

    public string Ctacar { get; set; } = null!;

    public string Cuenta { get; set; } = null!;

    public string Dui { get; set; } = null!;

    public string Cargo { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public string Cuentabancaria { get; set; } = null!;

    public decimal Pagoelectronico { get; set; }

    public string Banco { get; set; } = null!;

    public decimal Diasdecredito { get; set; }

    public string TipoProveedor { get; set; } = null!;

    public string TipoCuenta { get; set; } = null!;

    public string? Fax { get; set; }

    public decimal? Descuento { get; set; }

    public decimal? LimiteCre { get; set; }

    public decimal? Saldo { get; set; }
}

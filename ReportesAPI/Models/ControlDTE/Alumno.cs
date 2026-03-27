using System;
using System.Collections.Generic;

namespace ReportesAPI.Models.ControlDTE;

public partial class Alumno
{
    public int AlumnoId { get; set; }

    public double? IdSeccion { get; set; }

    public string? NombreGrado { get; set; }

    public string? Identificador { get; set; }

    public string? Turno { get; set; }

    public DateTime? FechaMatricula { get; set; }

    public double? Estado { get; set; }

    public double? IdParametro { get; set; }

    public double? TipoIngreso { get; set; }

    public string? Nie { get; set; }

    public string? EstudiantePrimerNombre { get; set; }

    public string? EstudianteSegundoNombre { get; set; }

    public string? EstudiantePrimerApellido { get; set; }

    public string? EstudianteSegundoApellido { get; set; }

    public string? Genero { get; set; }

    public double? IdAlumnos { get; set; }

    public double? Cuota { get; set; }

    public double? AnioLectivo { get; set; }

    public string? IdGrado { get; set; }

    public string? Religion { get; set; }

    public string? Nombre { get; set; }

    public string? CodInstitucion { get; set; }

    public string? Institucion { get; set; }

    public DateOnly? FechaNacimiento { get; set; }

    public string? NombreFactura { get; set; }

    public string? IdInterno { get; set; }

    public double Matricula { get; set; }

    public string? Nit { get; set; }

    public string? Dui { get; set; }

    public string? Direccion { get; set; }

    public string? Ciudad { get; set; }

    public string? Departamento { get; set; }

    public string? Coddepartamento { get; set; }

    public string? Codmunicipio { get; set; }

    public string? Pais { get; set; }

    public string? Codpais { get; set; }

    public string? Telefono { get; set; }

    public string? Email { get; set; }
}

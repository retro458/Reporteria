using ReportesAPI.Models;


/*
    @Erick Baudriz: Esta la interfaz define los métodos para generar los reportes en formato Excel y PDF tanto para el kardex como para las existencias.
    se implementa en ReportGeneratorService, donde se utiliza la biblioteca ClosedXML para Excel y iTextSharp para PDF, asegurando que los reportes sean profesionales y 
    fáciles de leer.

    @Author: Erick Baudriz


*/

namespace ReportesAPI.Services;

public interface IReportGeneratorService
{
    byte[] ExcelKardex(List<KardexRow> data, string codigo, string descripcion, DateTime desde, DateTime hasta, double saldoInicial);
    byte[] PdfKardex(List<KardexRow> data, string codigo, string descripcion, DateTime desde, DateTime hasta, double saldoInicial);
    byte[] ExcelExistencias(List<ExistenciaRow> data);
    byte[] PdfExistencias(List<ExistenciaRow> data);

   byte[] ExcelKardexGeneral(List<KardexGeneralRow> data, DateTime desde, DateTime hasta);
    byte[] PdfKardexGeneral(List<KardexGeneralRow> data, DateTime desde, DateTime hasta);
}
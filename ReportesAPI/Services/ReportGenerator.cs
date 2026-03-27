using OfficeOpenXml;
using OfficeOpenXml.Style;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using ReportesAPI.Models;
using System.Drawing;

namespace ReportesAPI.Services;

/*
    @Erick Baudriz : Este servicio se encarga exclusivamente de generar los archivos de Excel y PDF a partir de los datos que le pasen los controladores.
    @autor: Erick Baudriz
    @fecha: 2026-03-19

     - ExcelKardex: Genera un archivo Excel con el formato de Kardex, usando EPPlus.
     - ExcelExistencias: Genera un archivo Excel con el formato de Existencias, usando EPPlus.
     - PdfKardex: Genera un archivo PDF con el formato de Kardex, usando QuestPDF.
     - PdfExistencias: Genera un archivo PDF con el formato de Existencias, usando QuestPDF.

     Cada método recibe los datos necesarios para llenar el reporte y devuelve un arreglo de bytes que representa el archivo generado, listo para ser enviado al cliente o guardado en disco.

*/

public class ReportGeneratorService : IReportGeneratorService
{
    // ══════════════════════════════════════════════════════
    // EXCEL — KARDEX
    // ══════════════════════════════════════════════════════
    public byte[] ExcelKardex(List<KardexRow> data, string codigo, string descripcion, DateTime desde, DateTime hasta, double saldoInicial)
    {
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        using var package = new ExcelPackage();
        var ws = package.Workbook.Worksheets.Add("Kardex");

        // Título
        ws.Cells["A1"].Value = "KARDEX DE INVENTARIO";
        ws.Cells["A1:H1"].Merge = true;
        ws.Cells["A1"].Style.Font.Bold = true;
        ws.Cells["A1"].Style.Font.Size = 14;
        ws.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

        ws.Cells["A2"].Value = $"Producto: {codigo} — {descripcion}";
        ws.Cells["A2:H2"].Merge = true;
        ws.Cells["A2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

        ws.Cells["A3"].Value = $"Período: {desde:dd/MM/yyyy} al {hasta:dd/MM/yyyy}";
        ws.Cells["A3:H3"].Merge = true;
        ws.Cells["A3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
        ws.Cells["A3"].Style.Font.Color.SetColor(System.Drawing.Color.Gray);

        // Headers
        var headers = new[] { "Fecha", "Documento", "Correlativo", "Cliente/Proveedor", "Entrada", "Salida", "Saldo", "Costo Unit." };
        for (int i = 0; i < headers.Length; i++)
        {
            var cell = ws.Cells[5, i + 1];
            cell.Value = headers[i];
            cell.Style.Font.Bold = true;
            cell.Style.Fill.PatternType = ExcelFillStyle.Solid;
            cell.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(29, 29, 31));
            cell.Style.Font.Color.SetColor(System.Drawing.Color.White);
            cell.Style.HorizontalAlignment = i >= 4 ? ExcelHorizontalAlignment.Right : ExcelHorizontalAlignment.Left;
        }

        // ------- ajustar ancho de columnas según contenido --------
        ws.Column(4).Width = 50; // Ancho fijo para Cliente/Proveedor
        ws.Column(4).Style.WrapText = true; // Que el texto baje
        ws.Column(4).Style.VerticalAlignment = ExcelVerticalAlignment.Top; // Alineado arriba


        //--ajustar ancho de las demas columnas

        // Datos
        int row = 6; double saldoAcumulado = saldoInicial;
        ws.Cells[row, 1].Value = desde.ToString("dd/MM/yyyy");
        ws.Cells[row, 4].Value = "SALDO INICIAL AL " + desde.ToString("dd/MM/yyyy");
        ws.Cells[row, 7].Value = saldoInicial;
        ws.Cells[row, 1, row, 8].Style.Font.Bold = true;
        ws.Cells[row, 1, row, 8].Style.Fill.PatternType = ExcelFillStyle.Solid;
        ws.Cells[row, 1, row, 8].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(245, 245, 247));
        row++;

        foreach (var item in data)
        {
            saldoAcumulado += item.Entrada - item.Salida;
            var bg = item.Entrada > 0 ? System.Drawing.Color.FromArgb(232, 245, 233) : System.Drawing.Color.FromArgb(252, 228, 236);

            ws.Cells[row, 1].Value = item.Fecha.ToString("dd/MM/yyyy");
            ws.Cells[row, 2].Value = item.Documento;
            ws.Cells[row, 3].Value = item.Correlativo;
            ws.Cells[row, 4].Value = item.ClienteProveedor;
            ws.Cells[row, 5].Value = item.Entrada > 0 ? item.Entrada : (double?)null;
            ws.Cells[row, 6].Value = item.Salida > 0 ? item.Salida : (double?)null;
            ws.Cells[row, 7].Value = saldoAcumulado;
            ws.Cells[row, 8].Value = item.Costo > 0 ? item.Costo : (double?)null;

            ws.Cells[row, 1, row, 8].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells[row, 1, row, 8].Style.Fill.BackgroundColor.SetColor(bg);
            ws.Cells[row, 5].Style.Font.Color.SetColor(item.Entrada > 0 ? System.Drawing.Color.FromArgb(46, 125, 50) : System.Drawing.Color.Black);
            ws.Cells[row, 6].Style.Font.Color.SetColor(item.Salida > 0 ? System.Drawing.Color.FromArgb(198, 40, 40) : System.Drawing.Color.Black);
            ws.Cells[row, 5, row, 8].Style.Numberformat.Format = "#,##0.00";
            ws.Cells[row, 5, row, 8].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
            row++;
        }

        // Totales
        ws.Cells[row, 1, row, 4].Merge = true;
        ws.Cells[row, 1].Value = "TOTALES";
        ws.Cells[row, 1].Style.Font.Bold = true;
        ws.Cells[row, 5].Value = data.Sum(d => d.Entrada);
        ws.Cells[row, 6].Value = data.Sum(d => d.Salida);
        ws.Cells[row, 7].Value = saldoAcumulado;
        ws.Cells[row, 5, row, 8].Style.Font.Bold = true;
        ws.Cells[row, 5, row, 8].Style.Numberformat.Format = "#,##0.00";
        ws.Cells[row, 1, row, 8].Style.Fill.PatternType = ExcelFillStyle.Solid;
        ws.Cells[row, 1, row, 8].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(245, 245, 247));

        ws.Column(1).Width = 12; ws.Column(2).Width = 28; ws.Column(3).Width = 14;
        ws.Column(4).Width = 35; ws.Column(5).Width = 12; ws.Column(6).Width = 12;
        ws.Column(7).Width = 12; ws.Column(8).Width = 14;

        return package.GetAsByteArray();
    }

    // ══════════════════════════════════════════════════════
    // EXCEL — EXISTENCIAS
    // ══════════════════════════════════════════════════════
    public byte[] ExcelExistencias(List<ExistenciaRow> data)
    {
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        using var package = new ExcelPackage();
        var ws = package.Workbook.Worksheets.Add("Existencias");

        ws.Cells["A1"].Value = "REPORTE DE EXISTENCIAS DE INVENTARIO";
        ws.Cells["A1:I1"].Merge = true;
        ws.Cells["A1"].Style.Font.Bold = true;
        ws.Cells["A1"].Style.Font.Size = 14;
        ws.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
        ws.Cells["A2"].Value = $"Generado el {DateTime.Now:dd/MM/yyyy HH:mm}";
        ws.Cells["A2:I2"].Merge = true;
        ws.Cells["A2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
        ws.Cells["A2"].Style.Font.Color.SetColor(System.Drawing.Color.Gray);

        var headers = new[] { "Código", "Descripción", "Categoría", "Unidad", "Stock Mín.", "Existencia", "Costo Prom.", "Precio", "Estado" };
        for (int i = 0; i < headers.Length; i++)
        {
            var cell = ws.Cells[4, i + 1];
            cell.Value = headers[i];
            cell.Style.Font.Bold = true;
            cell.Style.Fill.PatternType = ExcelFillStyle.Solid;
            cell.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(29, 29, 31));
            cell.Style.Font.Color.SetColor(System.Drawing.Color.White);
        }

        int row = 5;
        foreach (var p in data)
        {
            string estado = p.Existencia <= 0 ? "Sin stock" : (p.StockMinimo > 0 && p.Existencia <= p.StockMinimo ? "Bajo mínimo" : "En stock");
            var bg = p.Existencia <= 0 ? System.Drawing.Color.FromArgb(252, 228, 236) : (p.StockMinimo > 0 && p.Existencia <= p.StockMinimo ? System.Drawing.Color.FromArgb(255, 248, 225) : System.Drawing.Color.FromArgb(232, 245, 233));

            ws.Cells[row, 1].Value = p.Codigo;
            ws.Cells[row, 2].Value = p.Descripcion;
            ws.Cells[row, 3].Value = p.Categoria;
            ws.Cells[row, 4].Value = p.Unidad;
            ws.Cells[row, 5].Value = p.StockMinimo;
            ws.Cells[row, 6].Value = p.Existencia;
            ws.Cells[row, 7].Value = p.CostoPromedio;
            ws.Cells[row, 8].Value = p.Precio;
            ws.Cells[row, 9].Value = estado;

            ws.Cells[row, 1, row, 9].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells[row, 1, row, 9].Style.Fill.BackgroundColor.SetColor(bg);
            ws.Cells[row, 5, row, 8].Style.Numberformat.Format = "#,##0.00";
            ws.Cells[row, 5, row, 8].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
            row++;
        }

        ws.Column(1).Width = 12; ws.Column(2).Width = 40; ws.Column(3).Width = 18;
        ws.Column(4).Width = 10; ws.Column(5).Width = 12; ws.Column(6).Width = 12;
        ws.Column(7).Width = 14; ws.Column(8).Width = 12; ws.Column(9).Width = 14;

        return package.GetAsByteArray();
    }

    // ══════════════════════════════════════════════════════
    // PDF — KARDEX
    // ══════════════════════════════════════════════════════
    public byte[] PdfKardex(List<KardexRow> data, string codigo, string descripcion, DateTime desde, DateTime hasta, double saldoInicial)
    {
        QuestPDF.Settings.License = LicenseType.Community;

        double totalEnt = data.Sum(d => d.Entrada);
        double totalSal = data.Sum(d => d.Salida);
        double saldoFin = saldoInicial + totalEnt - totalSal;

        var pdf = Document.Create(container =>
        {
            container.Page(page =>
            {
                page.Size(PageSizes.A4.Landscape());
                page.Margin(30);
                page.DefaultTextStyle(x => x.FontSize(9).FontFamily("Arial"));

                page.Header().Column(col =>
                {
                    col.Item().AlignCenter().Text("KARDEX DE INVENTARIO").FontSize(16).Bold();
                    col.Item().AlignCenter().Text($"Producto: {codigo} — {descripcion}").FontSize(11);
                    col.Item().AlignCenter().Text($"Período: {desde:dd/MM/yyyy} al {hasta:dd/MM/yyyy}").FontSize(9).FontColor("#86868b");
                    col.Item().Height(10);
                });

                page.Content().Column(col =>
                {
                    col.Item().Row(row =>
                    {
                        foreach (var (label, val, color) in new[] {
                            ("Total Entradas", $"{totalEnt:N2}", "#2e7d32"),
                            ("Total Salidas", $"{totalSal:N2}", "#c62828"),
                            ("Saldo Final", $"{saldoFin:N2}", "#1565c0"),
                            ("Movimientos", $"{data.Count}", "#1d1d1f") })
                        {
                            row.RelativeItem().Border(1).BorderColor("#e0e0e0").Padding(8).Column(c =>
                            {
                                c.Item().Text(label).FontSize(8).FontColor("#86868b");
                                c.Item().Text(val).FontSize(14).Bold().FontColor(color);
                            });
                            row.ConstantItem(10);
                        }
                    });

                    col.Item().Height(12);

                    col.Item().Table(table =>
                    {
                        table.ColumnsDefinition(cols =>
                        {
                            cols.ConstantColumn(60);
                            cols.RelativeColumn(3);
                            cols.ConstantColumn(65);
                            cols.RelativeColumn(4);
                            cols.ConstantColumn(60);
                            cols.ConstantColumn(60);
                            cols.ConstantColumn(60);
                            cols.ConstantColumn(65);
                        });

                        table.Header(h =>
                        {
                            foreach (var t in new[] { "Fecha", "Documento", "Correlativo", "Cliente/Proveedor", "Entrada", "Salida", "Saldo", "Costo Unit." })
                                h.Cell().Background("#1d1d1f").Padding(5).Text(t).FontSize(8).Bold().FontColor("#ffffff");
                        });

                        // --- FILA DE SALDO INICIAL ---
                        table.Cell().Background("#f5f5f7").Padding(4).Text(desde.ToString("dd/MM/yy")).FontSize(8);
                        table.Cell().Background("#f5f5f7").Padding(4).Text("").FontSize(8);
                        table.Cell().Background("#f5f5f7").Padding(4).Text("").FontSize(8);
                        table.Cell().Background("#f5f5f7").Padding(4).Text("SALDO INICIAL ANTERIOR").FontSize(8).Bold();
                        table.Cell().Background("#f5f5f7").Padding(4).Text("");
                        table.Cell().Background("#f5f5f7").Padding(4).Text("");
                        table.Cell().Background("#f5f5f7").Padding(4).AlignRight().Text($"{saldoInicial:N2}").FontSize(8).Bold();
                        table.Cell().Background("#f5f5f7").Padding(4).Text("");

                    double saldoRunning = saldoInicial;
                        foreach (var item in data)
                        {
                            saldoRunning += item.Entrada - item.Salida;
                            var bg = item.Entrada > 0 ? "#e8f5e9" : "#fce4ec";
                            IContainer Cell(IContainer c) => c.Background(bg).Padding(4);

                            table.Cell().Element(Cell).Text(item.Fecha.ToString("dd/MM/yy")).FontSize(8).FontColor("#555555");
                            table.Cell().Element(Cell).Text(item.Documento ?? "").FontSize(8);
                            table.Cell().Element(Cell).Text(item.Correlativo ?? "").FontSize(8).Bold();
                            table.Cell().Element(Cell).Text(item.ClienteProveedor ?? "").FontSize(8);
                            table.Cell().Background(bg).Padding(4).AlignRight().Text(item.Entrada > 0 ? $"+{item.Entrada:N2}" : "").FontSize(8).Bold().FontColor("#2e7d32");
                            table.Cell().Background(bg).Padding(4).AlignRight().Text(item.Salida > 0 ? $"-{item.Salida:N2}" : "").FontSize(8).Bold().FontColor("#c62828");
                            table.Cell().Background(bg).Padding(4).AlignRight().Text($"{saldoRunning:N2}").FontSize(8).Bold();
                            table.Cell().Background(bg).Padding(4).AlignRight().Text(item.Costo > 0 ? $"${item.Costo:N2}" : "—").FontSize(8);
                        }

                        IContainer TotalCell(IContainer c) => c.Background("#f5f5f7").Padding(5);
                        table.Cell().ColumnSpan(4).Element(TotalCell).Text("TOTALES").FontSize(9).Bold();
                        table.Cell().Element(TotalCell).AlignRight().Text($"+{totalEnt:N2}").FontSize(9).Bold().FontColor("#2e7d32");
                        table.Cell().Element(TotalCell).AlignRight().Text($"-{totalSal:N2}").FontSize(9).Bold().FontColor("#c62828");
                        table.Cell().Element(TotalCell).AlignRight().Text($"{saldoFin:N2}").FontSize(9).Bold();
                        table.Cell().Element(TotalCell).Text("");
                    });
                });

                page.Footer().AlignRight().Text($"Generado el {DateTime.Now:dd/MM/yyyy HH:mm} · CloudPocket Reportería").FontSize(7).FontColor("#86868b");
            });
        });

        var ms = new MemoryStream();
        pdf.GeneratePdf(ms);
        return ms.ToArray();
    }

    // ══════════════════════════════════════════════════════
    // PDF — EXISTENCIAS
    // ══════════════════════════════════════════════════════
    public byte[] PdfExistencias(List<ExistenciaRow> data)
    {
        QuestPDF.Settings.License = LicenseType.Community;

        int total = data.Count;
        int enStock = data.Count(p => p.Existencia > p.StockMinimo);
        int bajoMin = data.Count(p => p.Existencia > 0 && p.StockMinimo > 0 && p.Existencia <= p.StockMinimo);
        int sinStock = data.Count(p => p.Existencia <= 0);

        var pdf = Document.Create(container =>
        {
            container.Page(page =>
            {
                page.Size(PageSizes.A4.Landscape());
                page.Margin(30);
                page.DefaultTextStyle(x => x.FontSize(9).FontFamily("Arial"));

                page.Header().Column(col =>
                {
                    col.Item().AlignCenter().Text("REPORTE DE EXISTENCIAS DE INVENTARIO").FontSize(16).Bold();
                    col.Item().AlignCenter().Text($"Generado el {DateTime.Now:dd/MM/yyyy HH:mm}").FontSize(9).FontColor("#86868b");
                    col.Item().Height(10);
                });

                page.Content().Column(col =>
                {
                    col.Item().Row(row =>
                    {
                        foreach (var (label, val, color) in new[] {
                            ("Total Productos", total.ToString(), "#1565c0"),
                            ("En Stock", enStock.ToString(), "#2e7d32"),
                            ("Bajo Mínimo", bajoMin.ToString(), "#f57f17"),
                            ("Sin Stock", sinStock.ToString(), "#c62828") })
                        {
                            row.RelativeItem().Border(1).BorderColor("#e0e0e0").Padding(8).Column(c =>
                            {
                                c.Item().Text(label).FontSize(8).FontColor("#86868b");
                                c.Item().Text(val).FontSize(14).Bold().FontColor(color);
                            });
                            row.ConstantItem(8);
                        }
                    });

                    col.Item().Height(12);

                    col.Item().Table(table =>
                    {
                        table.ColumnsDefinition(cols =>
                        {
                            cols.ConstantColumn(55);
                            cols.RelativeColumn(4);
                            cols.RelativeColumn(2);
                            cols.ConstantColumn(45);
                            cols.ConstantColumn(55);
                            cols.ConstantColumn(55);
                            cols.ConstantColumn(60);
                            cols.ConstantColumn(60);
                            cols.ConstantColumn(65);
                        });

                        table.Header(h =>
                        {
                            foreach (var t in new[] { "Código", "Descripción", "Categoría", "Unidad", "Stock Mín.", "Existencia", "Costo Prom.", "Precio", "Estado" })
                                h.Cell().Background("#1d1d1f").Padding(5).Text(t).FontSize(8).Bold().FontColor("#ffffff");
                        });

                        foreach (var p in data)
                        {
                            string estado = p.Existencia <= 0 ? "Sin stock" : (p.StockMinimo > 0 && p.Existencia <= p.StockMinimo ? "Bajo mínimo" : "En stock");
                            string bg = p.Existencia <= 0 ? "#fce4ec" : (p.StockMinimo > 0 && p.Existencia <= p.StockMinimo ? "#fff8e1" : "#e8f5e9");
                            string color = p.Existencia <= 0 ? "#c62828" : (p.StockMinimo > 0 && p.Existencia <= p.StockMinimo ? "#f57f17" : "#2e7d32");

                            IContainer Cell(IContainer c) => c.Background(bg).Padding(4);

                            table.Cell().Element(Cell).Text(p.Codigo ?? "").FontSize(8).Bold().FontColor("#0071e3");
                            table.Cell().Element(Cell).Text(p.Descripcion ?? "").FontSize(8);
                            table.Cell().Element(Cell).Text(p.Categoria ?? "—").FontSize(8).FontColor("#555");
                            table.Cell().Element(Cell).Text(p.Unidad ?? "—").FontSize(8).FontColor("#555");
                            table.Cell().Background(bg).Padding(4).AlignRight().Text($"{p.StockMinimo:N2}").FontSize(8);
                            table.Cell().Background(bg).Padding(4).AlignRight().Text($"{p.Existencia:N2}").FontSize(8).Bold().FontColor(color);
                            table.Cell().Background(bg).Padding(4).AlignRight().Text($"${p.CostoPromedio:N2}").FontSize(8);
                            table.Cell().Background(bg).Padding(4).AlignRight().Text($"${p.Precio:N2}").FontSize(8);
                            table.Cell().Background(bg).Padding(4).Text(estado).FontSize(8).Bold().FontColor(color);
                        }
                    });
                });

                page.Footer().AlignRight().Text($"Generado el {DateTime.Now:dd/MM/yyyy HH:mm} · CloudPocket Reportería").FontSize(7).FontColor("#86868b");
            });
        });

        var ms = new MemoryStream();
        pdf.GeneratePdf(ms);
        return ms.ToArray();
    }


    // ------------------------------------------
    // Excel - Kardex General
    // -----------------------------------------

  public byte[] ExcelKardexGeneral(List<KardexGeneralRow> data, DateTime desde, DateTime hasta)
{
    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
    using var package = new ExcelPackage();
    var ws = package.Workbook.Worksheets.Add("Kardex General");

    // Título y Período (Ajustado a J porque son 10 columnas: A-J)
    ws.Cells["A1"].Value = "KARDEX GENERAL DE INVENTARIO";
    ws.Cells["A1:J1"].Merge = true;
    ws.Cells["A1"].Style.Font.Bold = true;
    ws.Cells["A1"].Style.Font.Size = 14;
    ws.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

    ws.Cells["A2"].Value = $"Período: {desde:dd/MM/yyyy} al {hasta:dd/MM/yyyy}";
    ws.Cells["A2:J2"].Merge = true;
    ws.Cells["A2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
    ws.Cells["A2"].Style.Font.Color.SetColor(System.Drawing.Color.Gray);

    // Encabezados (Ahora son 10)
    var headers = new[] { "Fecha", "Código", "Descripción", "Documento", "Correlativo", "Cliente/Proveedor", "Entrada", "Salida", "Saldo Acumulado", "Costo Unit." };
    for (int i = 0; i < headers.Length; i++)
    {
        var cell = ws.Cells[4, i + 1];
        cell.Value = headers[i];
        cell.Style.Font.Bold = true;
        cell.Style.Fill.PatternType = ExcelFillStyle.Solid;
        cell.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(29, 29, 31));
        cell.Style.Font.Color.SetColor(System.Drawing.Color.White);
        // Alineación a la derecha desde Entrada (col 7) hasta Costo (col 10)
        cell.Style.HorizontalAlignment = i >= 6 ? ExcelHorizontalAlignment.Right : ExcelHorizontalAlignment.Left;
    }

    int row = 5;
    foreach (var item in data)
    {
        var bg = item.Entrada > 0
            ? System.Drawing.Color.FromArgb(232, 245, 233)
            : System.Drawing.Color.FromArgb(252, 228, 236);

        ws.Cells[row, 1].Value = item.Fecha.ToString("dd/MM/yyyy");
        ws.Cells[row, 2].Value = item.Codigo;
        ws.Cells[row, 3].Value = item.Descripcion;
        ws.Cells[row, 4].Value = item.Documento;
        ws.Cells[row, 5].Value = item.Correlativo;
        ws.Cells[row, 6].Value = item.ClienteProveedor;
        ws.Cells[row, 7].Value = item.Entrada > 0 ? item.Entrada : (double?)null;
        ws.Cells[row, 8].Value = item.Salida  > 0 ? item.Salida  : (double?)null;
        
        // NUEVO: Saldo Acumulado en la columna 9
        ws.Cells[row, 9].Value = item.SaldoAcumulado;
        
        // Costo Unitario se mueve a la columna 10
        ws.Cells[row, 10].Value = item.Costo > 0 ? item.Costo : (double?)null;

        // Estilo de fila (A-J es 1-10)
        ws.Cells[row, 1, row, 10].Style.Fill.PatternType = ExcelFillStyle.Solid;
        ws.Cells[row, 1, row, 10].Style.Fill.BackgroundColor.SetColor(bg);

        // Colores de fuente para Entradas y Salidas
        ws.Cells[row, 7].Style.Font.Color.SetColor(item.Entrada > 0 ? System.Drawing.Color.FromArgb(46, 125, 50) : System.Drawing.Color.Black);
        ws.Cells[row, 8].Style.Font.Color.SetColor(item.Salida > 0 ? System.Drawing.Color.FromArgb(198, 40, 40) : System.Drawing.Color.Black);
        
        // Formato numérico para las últimas 4 columnas (7, 8, 9, 10)
        ws.Cells[row, 7, row, 10].Style.Numberformat.Format = "#,##0.00";
        ws.Cells[row, 7, row, 10].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
        
        row++;
    }

    // Totales (Ajustado a columna 10)
    ws.Cells[row, 1, row, 6].Merge = true;
    ws.Cells[row, 1].Value = "TOTALES";
    ws.Cells[row, 1].Style.Font.Bold = true;
    ws.Cells[row, 7].Value = data.Sum(d => d.Entrada);
    ws.Cells[row, 8].Value = data.Sum(d => d.Salida);
    
    ws.Cells[row, 7, row, 10].Style.Font.Bold = true;
    ws.Cells[row, 7, row, 10].Style.Numberformat.Format = "#,##0.00";
    ws.Cells[row, 1, row, 10].Style.Fill.PatternType = ExcelFillStyle.Solid;
    ws.Cells[row, 1, row, 10].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(245, 245, 247));

    // Ajuste de anchos final
    ws.Column(1).Width = 12; 
    ws.Column(2).Width = 12; 
    ws.Column(3).Width = 40;
    ws.Column(4).Width = 28; 
    ws.Column(5).Width = 14; 
    ws.Column(6).Width = 45; // Cliente
    ws.Column(7).Width = 12; 
    ws.Column(8).Width = 12; 
    ws.Column(9).Width = 15; // Saldo Acumulado
    ws.Column(10).Width = 12; // Costo
    // Habilitar el ajuste de texto en las columnas con contenido largo
    ws.Column(3).Style.WrapText = true; // Descripción
    ws.Column(6).Style.WrapText = true; // Cliente/Proveedor

    // Alinear todo al tope superior para que si una fila crece, el resto no se vea raro
    ws.Cells[5, 1, row, 10].Style.VerticalAlignment = ExcelVerticalAlignment.Top;
    return package.GetAsByteArray();
}

    // ------------------------------------------
    // PDF - Kardex General
    // -----------------------------------------
    public byte[] PdfKardexGeneral(List<KardexGeneralRow> data, DateTime desde, DateTime hasta)
    {
        QuestPDF.Settings.License = LicenseType.Community;

        double totalEnt = data.Sum(d => d.Entrada);
        double totalSal = data.Sum(d => d.Salida);

        var pdf = Document.Create(container =>
        {
            container.Page(page =>
            {
                page.Size(PageSizes.A4.Landscape());
                page.Margin(30);
                page.DefaultTextStyle(x => x.FontSize(8).FontFamily("Arial"));

                page.Header().Column(col =>
                {
                    col.Item().AlignCenter().Text("KARDEX GENERAL DE INVENTARIO").FontSize(16).Bold();
                    col.Item().AlignCenter().Text($"Período: {desde:dd/MM/yyyy} al {hasta:dd/MM/yyyy}")
                        .FontSize(9).FontColor("#86868b");
                    col.Item().Height(10);
                });

                page.Content().Column(col =>
                {
                    // KPIs
                    col.Item().Row(row =>
                    {
                        foreach (var (label, val, color) in new[] {
                        ("Total Entradas",  $"{totalEnt:N2}", "#2e7d32"),
                        ("Total Salidas",   $"{totalSal:N2}", "#c62828"),
                        ("Movimientos",     $"{data.Count}",  "#1d1d1f") })
                        {
                            row.RelativeItem().Border(1).BorderColor("#e0e0e0").Padding(8).Column(c =>
                            {
                                c.Item().Text(label).FontSize(8).FontColor("#86868b");
                                c.Item().Text(val).FontSize(14).Bold().FontColor(color);
                            });
                            row.ConstantItem(10);
                        }
                    });

                    col.Item().Height(12);

                    col.Item().Table(table =>
                    {
                        table.ColumnsDefinition(cols =>
                        {
                            cols.ConstantColumn(50);  // Fecha
                            cols.ConstantColumn(45);  // Código
                            cols.RelativeColumn(3);   // Descripción
                            cols.RelativeColumn(2);   // Documento
                            cols.ConstantColumn(55);  // Correlativo
                            cols.RelativeColumn(2.5f);   // Cliente
                            cols.ConstantColumn(55);  // Entrada
                            cols.ConstantColumn(55);  // Salida
                            cols.ConstantColumn(50);  // Saldo
                            cols.ConstantColumn(55);  // Costo
                        });

                        table.Header(h =>
                        {
                            foreach (var t in new[] { "Fecha", "Código", "Descripción", "Documento", "Correlativo", "Cliente/Proveedor", "Entrada", "Salida", "Saldo", "Costo" })
                                h.Cell().Background("#1d1d1f").Padding(4)
                                    .Text(t).FontSize(7).Bold().FontColor("#ffffff");
                        });

                        foreach (var item in data)
                        {
                            var bg = item.Entrada > 0 ? "#e8f5e9" : "#fce4ec";
                            IContainer Cell(IContainer c) => c.Background(bg).Padding(3);

                                table.Cell().Element(Cell).Text(item.Fecha.ToString("dd/MM/yy")).FontSize(7).FontColor("#555");
                                table.Cell().Element(Cell).Text(item.Codigo ?? "").FontSize(7).Bold().FontColor("#0071e3");
                                table.Cell().Element(Cell).Text(item.Descripcion ?? "").FontSize(7);
                                table.Cell().Element(Cell).Text(item.Documento ?? "").FontSize(7);
                                table.Cell().Element(Cell).Text(item.Correlativo ?? "").FontSize(7).Bold();
                                table.Cell().Element(Cell).Text(item.ClienteProveedor ?? "").FontSize(7);
                                
                                  // Entrada
                                    table.Cell().Element(Cell).AlignRight()
                                    .Text(item.Entrada > 0 ? $"+{item.Entrada:N2}" : "").FontSize(7).Bold().FontColor("#2e7d32");
                                
                                 // Salida
                                 table.Cell().Element(Cell).AlignRight()
                                    .Text(item.Salida > 0 ? $"-{item.Salida:N2}" : "").FontSize(7).Bold().FontColor("#c62828");

                                    // --- COLUMNA DE SALDO ACUMULADO ---
                                    table.Cell().Element(Cell).AlignRight()
                                    .Text($"{item.SaldoAcumulado:N2}").FontSize(7).Bold();

                                  // Costo
                                    table.Cell().Element(Cell).AlignRight()
                                    .Text(item.Costo > 0 ? $"${item.Costo:N2}" : "—").FontSize(7);
                        }

                        IContainer TotalCell(IContainer c) => c.Background("#f5f5f7").Padding(5);
                        table.Cell().ColumnSpan(6).Element(TotalCell).Text("TOTALES").FontSize(8).Bold();
                        table.Cell().Element(TotalCell).AlignRight().Text($"+{totalEnt:N2}").FontSize(8).Bold().FontColor("#2e7d32");
                        table.Cell().Element(TotalCell).AlignRight().Text($"-{totalSal:N2}").FontSize(8).Bold().FontColor("#c62828");
                        table.Cell().Element(TotalCell).Text(""); // Espacio para la columna Saldo
                        table.Cell().Element(TotalCell).Text(""); // Espacio para la columna Costo
                    });
                });

                page.Footer().AlignRight()
                    .Text($"Generado el {DateTime.Now:dd/MM/yyyy HH:mm} · CloudPocket Reportería")
                    .FontSize(7).FontColor("#86868b");
            });
        });

        var ms = new MemoryStream();
        pdf.GeneratePdf(ms);
        return ms.ToArray();
    }
} 
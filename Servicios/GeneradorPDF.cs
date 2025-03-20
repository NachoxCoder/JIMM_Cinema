using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using BE;
using System.IO;
using System.Xml.Linq;


namespace Servicios
{
    public class GeneradorPDF
    {
        public string GenerarBoletoPDF(BE_Boleto boleto)
        {
			try
			{
                string boletosPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "BOLETOS");
                if (!Directory.Exists(boletosPath))
                {
                    Directory.CreateDirectory(boletosPath);
                }

                string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string fileName = $"Boleto_{boleto.ID}_{boleto.Cliente.NombreCompleto()}_{timestamp}.pdf";
                string filePath = Path.Combine(boletosPath, fileName);

                //Creamos un rectangulo para customizar el tamaño del ticket
                Rectangle ticket= new Rectangle(226, 425);
                //Reducimos los margenes
                Document document = new Document(ticket, 20, 20, 20, 20);

                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();

                //Titulo
                Paragraph titulo = new Paragraph("BOLETO DE CINE", new Font(Font.FontFamily.HELVETICA, 14, Font.BOLD));
                titulo.Alignment = Element.ALIGN_CENTER;
                document.Add(titulo);

                Paragraph nombreCine = new Paragraph("JIMM CINEMA", new Font(Font.FontFamily.HELVETICA, 12, Font.BOLD));
                nombreCine.Alignment = Element.ALIGN_CENTER;
                document.Add(nombreCine);
                document.Add(new Paragraph("\n"));

                //ID y fecha del Boleto
                document.Add(new Paragraph($"BOLETO #: {boleto.ID}", new Font(Font.FontFamily.HELVETICA, 9, Font.BOLD)));
                document.Add(new Paragraph($"Fecha: {boleto.FechaVenta:dd/MM/yyyy}", new Font(Font.FontFamily.HELVETICA, 9)));
                document.Add(new Paragraph($"Hora: {boleto.FechaVenta:HH:mm}", new Font(Font.FontFamily.HELVETICA, 9)));
                document.Add(new Paragraph("\n"));

                //Informacion del Cliente
                document.Add(new Paragraph($"Nombre: {boleto.Cliente.NombreCompleto()}", new Font(Font.FontFamily.HELVETICA, 9)));
                document.Add(new Paragraph($"DNI: {boleto.Cliente.DNI}", new Font(Font.FontFamily.HELVETICA, 9)));
                document.Add(new Paragraph("\n"));


                //Informacion de la Funcion
                document.Add(new Paragraph("PELÍCULA", new Font(Font.FontFamily.HELVETICA, 9, Font.BOLD)));
                document.Add(new Paragraph($"{boleto.Funcion.Pelicula.Titulo}", new Font(Font.FontFamily.HELVETICA, 9)));
                document.Add(new Paragraph($"Sala: {boleto.Funcion.Sala.Nombre}", new Font(Font.FontFamily.HELVETICA, 9)));
                document.Add(new Paragraph($"Fecha: {boleto.Funcion.FechaFuncion:dd/MM/yyyy}", new Font(Font.FontFamily.HELVETICA, 9)));
                document.Add(new Paragraph($"Hora: {boleto.Funcion.HoraInicio:hh\\:mm} - {boleto.Funcion.HoraFin:hh\\:mm}", new Font(Font.FontFamily.HELVETICA, 9)));
                document.Add(new Paragraph("\n"));

                //Informacion Butacas reservadas
                document.Add(new Paragraph("BUTACAS", new Font(Font.FontFamily.HELVETICA, 9, Font.BOLD)));

                PdfPTable table = new PdfPTable(2);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 1f, 1f });
                table.HorizontalAlignment = Element.ALIGN_LEFT;

                PdfPCell cell = new PdfPCell(new Phrase("Fila", new Font(Font.FontFamily.HELVETICA, 9, Font.BOLD)));
                cell.HorizontalAlignment = Element.ALIGN_LEFT;
                cell.BorderWidth = 0;
                table.AddCell(cell);

                cell = new PdfPCell(new Phrase("Asiento", new Font(Font.FontFamily.HELVETICA, 9, Font.BOLD)));
                cell.HorizontalAlignment = Element.ALIGN_LEFT;
                cell.BorderWidth = 0;
                table.AddCell(cell);

                foreach(BE_Butaca butaca in boleto.Butacas)
                {
                    cell = new PdfPCell(new Phrase(butaca.Fila, new Font(Font.FontFamily.HELVETICA, 9)));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.BorderWidth = 0;
                    table.AddCell(cell);

                    // Asiento cell
                    cell = new PdfPCell(new Phrase(butaca.Numero.ToString(), new Font(Font.FontFamily.HELVETICA, 9)));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.BorderWidth = 0;
                    table.AddCell(cell);
                }

                document.Add(table);
                document.Add(new Paragraph("\n"));

                //Detalles de Pago
                document.Add(new Paragraph("DETALLE DE PAGO", new Font(Font.FontFamily.HELVETICA, 9, Font.BOLD)));

                PdfPTable Tablapago = new PdfPTable(2);
                Tablapago.WidthPercentage = 100;
                Tablapago.SetWidths(new float[] { 3f, 1f });
                Tablapago.HorizontalAlignment = Element.ALIGN_LEFT;

                decimal subtotal = boleto.Funcion.Precio * boleto.Butacas.Count;
                decimal descuento = subtotal - boleto.Precio;
                decimal totalAPagar = boleto.Precio;

                cell = new PdfPCell(new Phrase("Subtotal", new Font(Font.FontFamily.HELVETICA, 8)));
                cell.BorderWidth = 0;
                Tablapago.AddCell(cell);

                cell = new PdfPCell(new Phrase($"${subtotal:N2}", new Font(Font.FontFamily.HELVETICA, 8)));
                cell.BorderWidth = 0;
                cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                Tablapago.AddCell(cell);

                //Si existen descuentos
                if (descuento > 0)
                {
                    cell = new PdfPCell(new Phrase("Descuento por Membresia", new Font(Font.FontFamily.HELVETICA, 8)));
                    cell.BorderWidth = 0;
                    Tablapago.AddCell(cell);

                    cell = new PdfPCell(new Phrase($"-${descuento:N2}", new Font(Font.FontFamily.HELVETICA, 8)));
                    cell.BorderWidth = 0;
                    cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                    Tablapago.AddCell(cell);
                }

                cell = new PdfPCell(new Phrase("Total", new Font(Font.FontFamily.HELVETICA, 8, Font.BOLD)));
                cell.BorderWidth = 0;
                Tablapago.AddCell(cell);

                cell = new PdfPCell(new Phrase($"${totalAPagar:N2}", new Font(Font.FontFamily.HELVETICA, 8, Font.BOLD)));
                cell.BorderWidth = 0;
                cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                Tablapago.AddCell(cell);

                document.Add(Tablapago);
                document.Add(new Paragraph("\n"));

                document.Add(new Paragraph($"Método de Pago: {boleto.Metodo}", new Font(Font.FontFamily.HELVETICA, 8)));
                document.Add(new Paragraph("\n"));

                document.Add(new Paragraph("¡Gracias por su compra!", new Font(Font.FontFamily.HELVETICA, 8)));
                document.Add(new Paragraph("Por favor llegue 15 minutos antes.", new Font(Font.FontFamily.HELVETICA, 8)));

                document.Close();
                return filePath;
               
            }
			catch (Exception ex)
			{

                throw new Exception($"Error al generar PDF del boleto: {ex.Message}", ex);
            }
        }

        public string GenerarReporteDashboard(Dictionary<string, object> datosGenerales, Dictionary<string, int> datosPeliculas,
                                              Dictionary<string, double> datosOcupacion, Dictionary<string, int> datosMembresias, 
                                              List<BE_Producto> productosLowStock, DateTime fechaDesde, DateTime fechaHasta, string filePath)
        {
            try
            {
                Document doc = new Document(PageSize.A4);
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                doc.Open();

                Paragraph titulo = new Paragraph("Reporte Dashboard", new Font(Font.FontFamily.HELVETICA, 18, Font.BOLD));
                titulo.Alignment = Element.ALIGN_CENTER;
                doc.Add(titulo);
                doc.Add(new Paragraph(" "));

                Paragraph periodo = new Paragraph($"Periodo desde: {fechaDesde:dd/MM/yyyy} - hasta: {fechaHasta:dd/MM/yyyy}",
                    new Font(Font.FontFamily.HELVETICA, 12));
                doc.Add(periodo);
                doc.Add(new Paragraph(" "));

                Paragraph resumen = new Paragraph("Resumen General", new Font(Font.FontFamily.HELVETICA,
                    16, Font.BOLD));
                doc.Add(resumen);
                doc.Add(new Paragraph(" "));

                PdfPTable tablaResumen = new PdfPTable(2);
                tablaResumen.WidthPercentage = 80;
                tablaResumen.SetWidths(new float[] { 1, 1 });

                tablaResumen.AddCell("Boletos Vendidos");
                tablaResumen.AddCell(datosGenerales.ContainsKey("BoletosVendidosPeriodo") ?
                                     datosGenerales["BoletosVendidosPeriodo"].ToString() : "0");

                tablaResumen.AddCell("Membresias Activas");
                tablaResumen.AddCell(datosGenerales.ContainsKey("NuevasMembresias") ? datosGenerales["NuevasMembresias"].ToString() : "0");

                tablaResumen.AddCell("Total Recaudado");
                tablaResumen.AddCell(datosGenerales.ContainsKey("VentasPeriodo") ?
                                    $"${Convert.ToDecimal(datosGenerales["VentasPeriodo"]):N2}" : "$0.00");

                doc.Add(tablaResumen);
                doc.Add(new Paragraph(" "));

                Paragraph graficos = new Paragraph("GRÁFICOS", new Font(Font.FontFamily.HELVETICA, 14, Font.BOLD));
                doc.Add(graficos);
                doc.Add(new Paragraph(" "));

                if (File.Exists("tempPeliculasChart.png"))
                {
                    doc.Add(new Paragraph("Películas más vistas - Cantidad de boletos vendidos",
                        new Font(Font.FontFamily.HELVETICA, 12, Font.BOLD)));
                    Image imagenPeliculas = Image.GetInstance("tempPeliculasChart.png");
                    imagenPeliculas.ScalePercent(75);
                    doc.Add(imagenPeliculas);
                    doc.Add(new Paragraph(" "));
                }

                if (File.Exists("tempOcupacionChart.png"))
                {
                    doc.Add(new Paragraph("Porcentaje de ocupación de salas", new Font(Font.FontFamily.HELVETICA, 12, Font.BOLD)));
                    Image imagenOcupacion = Image.GetInstance("tempOcupacionChart.png");
                    imagenOcupacion.ScalePercent(75);
                    doc.Add(imagenOcupacion);
                    doc.Add(new Paragraph(" "));
                }

                if (File.Exists("tempMembresiasChart.png"))
                {
                    doc.Add(new Paragraph("Membresias activas por tipo", new Font(Font.FontFamily.HELVETICA, 12, Font.BOLD)));
                    Image imagenMembresias = Image.GetInstance("tempMembresiasChart.png");
                    imagenMembresias.ScalePercent(75);
                    doc.Add(imagenMembresias);
                    doc.Add(new Paragraph(" "));
                }

                if(File.Exists("tempAnalisisIngresosChart.png"))
                {
                    doc.Add(new Paragraph("Tendencia de ingresos", new Font(Font.FontFamily.HELVETICA, 12, Font.BOLD)));
                    Image imagenIngresos = Image.GetInstance("tempAnalisisIngresosChart.png");
                    imagenIngresos.ScalePercent(75);
                    doc.Add(imagenIngresos);
                    doc.Add(new Paragraph(" "));
                }

                Paragraph productos = new Paragraph("PRODUCTOS CON BAJO STOCK", new Font(Font.FontFamily.HELVETICA, 14, Font.BOLD));
                doc.Add(productos);
                doc.Add(new Paragraph(" "));

                PdfPTable tablaProductos = new PdfPTable(3);
                tablaProductos.WidthPercentage = 100;
                tablaProductos.SetWidths(new float[] { 2, 4, 1 });

                tablaProductos.AddCell(new PdfPCell(new Phrase("Nombre", new Font(Font.FontFamily.HELVETICA, 12, Font.BOLD))));
                tablaProductos.AddCell(new PdfPCell(new Phrase("Descripción", new Font(Font.FontFamily.HELVETICA, 12, Font.BOLD))));
                tablaProductos.AddCell(new PdfPCell(new Phrase("Stock", new Font(Font.FontFamily.HELVETICA, 12, Font.BOLD))));

                foreach (var producto in productosLowStock)
                {
                    tablaProductos.AddCell(producto.NombreProducto);
                    tablaProductos.AddCell(producto.DescripcionProducto);
                    tablaProductos.AddCell(producto.Stock.ToString());
                }

                doc.Add(tablaProductos);

                doc.Close();

                return filePath;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al generar PDF del dashboard: {ex.Message}", ex);
            }
        }
    }
}

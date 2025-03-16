using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BLL;
using BE;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace JIMM_Cinema
{
    public partial class Fr_Dashboard: Form
    {
        private readonly BLL_Dashboard _gestorDashboard;
        private readonly BLL_Producto _gestorProducto;
        public Fr_Dashboard()
        {
            InitializeComponent();
            _gestorDashboard = new BLL_Dashboard();
            _gestorProducto = new BLL_Producto();
            dtpFechaDesde.Value = DateTime.Today.AddMonths(-1);
            dtpFechaHasta.Value = DateTime.Today;
        }

        private void Fr_Dashboard_Load(object sender, EventArgs e)
        {
            ConfigurarGraficos();
            CargarDatos();
            CargarProductosBajoStock();
        }

        private void ConfigurarGraficos()
        {
            chartPeliculas.Series.Clear();
            chartPeliculas.Palette = ChartColorPalette.BrightPastel;
            chartPeliculas.BackColor = Color.WhiteSmoke;
            chartPeliculas.BorderlineColor = Color.LightGray;
            chartPeliculas.BorderlineDashStyle = ChartDashStyle.Solid;
            chartPeliculas.BorderlineWidth = 1;

            var seriePeliculas = new Series("Boletos Vendidos")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true,
                LabelFormat = "{0}",
                Font = new System.Drawing.Font("Segoe UI", 9, FontStyle.Bold),
                Color = Color.DodgerBlue,
                BorderColor = Color.Navy,
                BorderWidth = 1
            };
            chartPeliculas.Series.Add(seriePeliculas);

            chartPeliculas.ChartAreas[0].BackColor = Color.White;
            chartPeliculas.ChartAreas[0].BorderColor = Color.LightGray;
            chartPeliculas.ChartAreas[0].BorderWidth = 1;
            chartPeliculas.ChartAreas[0].AxisX.Title = "Películas";
            chartPeliculas.ChartAreas[0].AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 10, FontStyle.Bold);
            chartPeliculas.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8);
            chartPeliculas.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartPeliculas.ChartAreas[0].AxisY.Title = "Puestos Vendidos";
            chartPeliculas.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("Segoe UI", 10, FontStyle.Bold);
            chartPeliculas.ChartAreas[0].AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8);
            chartPeliculas.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chartPeliculas.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
            chartPeliculas.Legends[0].Enabled = false;

            chartOcupacion.Series.Clear();
            chartOcupacion.Palette = ChartColorPalette.Excel;
            chartOcupacion.BackColor = Color.WhiteSmoke;
            chartOcupacion.BorderlineColor = Color.LightGray;
            chartOcupacion.BorderlineDashStyle = ChartDashStyle.Solid;
            chartOcupacion.BorderlineWidth = 1;

            var serieOcupacion = new Series("Ocupacion")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true,
                LabelFormat = "{0}%",
                Font = new System.Drawing.Font("Segoe UI", 9, FontStyle.Bold)
            };
            chartOcupacion.Series.Add(serieOcupacion);
            
            chartOcupacion.ChartAreas[0].BackColor = Color.White;
            chartOcupacion.Legends[0].Enabled = true;
            chartOcupacion.Legends[0].Docking = Docking.Bottom;
            chartOcupacion.Legends[0].BackColor = Color.White;
            chartOcupacion.Legends[0].Font = new System.Drawing.Font("Segoe UI", 9);
            chartOcupacion.ChartAreas[0].Area3DStyle.Enable3D = true;
            chartOcupacion.ChartAreas[0].Area3DStyle.Inclination = 30;
            chartOcupacion.ChartAreas[0].Area3DStyle.LightStyle = LightStyle.Realistic;

            chartTotalMembresias.Series.Clear();
            chartTotalMembresias.Palette = ChartColorPalette.Berry;
            chartTotalMembresias.BackColor = Color.WhiteSmoke;
            chartTotalMembresias.BorderlineColor = Color.LightGray;
            chartTotalMembresias.BorderlineDashStyle = ChartDashStyle.Solid;
            chartTotalMembresias.BorderlineWidth = 1;

            var serieMembresias = new Series("Membresias Activas")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true,
                LabelFormat = "{0}",
                Font = new System.Drawing.Font("Segoe UI", 9, FontStyle.Bold)
            };

            chartTotalMembresias.Series.Add(serieMembresias);
            chartTotalMembresias.ChartAreas[0].BackColor = Color.White;
            chartTotalMembresias.Legends[0].Docking = Docking.Bottom;
            chartTotalMembresias.Legends[0].BackColor = Color.White;
            chartTotalMembresias.Legends[0].Font = new System.Drawing.Font("Segoe UI", 9);
            chartTotalMembresias.ChartAreas[0].Area3DStyle.Enable3D = true;
            chartTotalMembresias.ChartAreas[0].Area3DStyle.Inclination = 30;
        }

        private void CargarDatos()
        {
            try
            {
                var datosGenerales = _gestorDashboard.ObtenerDatos(dtpFechaDesde.Value, dtpFechaHasta.Value);

                lblBoletosVendidos.Text = datosGenerales.ContainsKey("BoletosVendidosPeriodo") ? 
                    datosGenerales["BoletosVendidosPeriodo"].ToString() : "0";
                lblNuevasMembresias.Text = datosGenerales.ContainsKey("NuevasMembresias") ?
                    datosGenerales["NuevasMembresias"].ToString() : "0";
                lblTotalRecaudado.Text = datosGenerales.ContainsKey("VentasPeriodo") ?
                    $"${Convert.ToDecimal(datosGenerales["VentasPeriodo"]):N2}" : "$0.00";

                var datosPelicula = _gestorDashboard.ObtenerDatosPeliculas(dtpFechaDesde.Value, dtpFechaHasta.Value);
                chartPeliculas.Series[0].Points.Clear();
                if (datosPelicula.Count == 0)
                {
                    var point = chartPeliculas.Series[0].Points.Add(100);
                    point.AxisLabel = "Sin datos";
                    point.Label = "Sin datos";
                    point.Color = Color.LightGray;
                }
                else
                {
                    Color[] colores = { Color.DodgerBlue, Color.Crimson, Color.ForestGreen, Color.Orange, Color.MediumPurple };
                    int colorIndex = 0;

                    foreach (var item in datosPelicula)
                    {
                        var point = chartPeliculas.Series[0].Points.Add(item.Value);
                        point.AxisLabel = item.Key;
                        point.Label = item.Value.ToString();
                        point.ToolTip = $"{item.Key}: {item.Value} boletos";
                        point.Color = colorIndex < colores.Length ? colores[colorIndex] : Color.Gray;
                        colorIndex++;
                    }
                }

                var datosOcupacion = _gestorDashboard.ObtenerDatosOcupacion(dtpFechaDesde.Value, dtpFechaHasta.Value);
                chartOcupacion.Series[0].Points.Clear();

                bool sinDatos = datosOcupacion.Count == 1 && datosOcupacion.ContainsKey("Sin datos");

                foreach (var item in datosOcupacion)
                {
                    var point = chartOcupacion.Series[0].Points.Add(item.Value);
                    point.AxisLabel = item.Key;
                    point.Label = sinDatos ? "Sin datos" : $"{item.Value:N1}%";
                    point.LegendText = item.Key;

                    if(item.Key == "Sin datos")
                    {
                        point.Color = Color.LightGray;
                    }
                }

                chartOcupacion.Series[0].IsVisibleInLegend = true;
                chartOcupacion.ChartAreas[0].Area3DStyle.Enable3D = true;
                chartOcupacion.Invalidate();

                var datosMembresias = _gestorDashboard.ObtenerMembresiasActivasPorTipo();
                chartTotalMembresias.Series[0].Points.Clear();
                foreach (var item in datosMembresias)
                {
                    var point = chartTotalMembresias.Series[0].Points.Add(item.Value);
                    point.AxisLabel = item.Key;
                    point.Label = item.Value.ToString();
                    point.ToolTip = $"{item.Key}: {item.Value} membresias";
                    point.LegendText = item.Key;
                }

                chartPeliculas.Invalidate();
                chartOcupacion.Invalidate();
                chartTotalMembresias.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos del dashboard: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProductosBajoStock()
        {
            try
            {
                var productosLowStock = _gestorProducto.ConsultarConStockBajo();
                dgvProductosLowStock.DataSource = productosLowStock;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos bajo stock: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DtpFecha_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaDesde.Value > dtpFechaHasta.Value)
            {
                MessageBox.Show("La fecha desde no puede ser mayor a la fecha hasta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaDesde.Value = dtpFechaHasta.Value.AddMonths(-1);
                return;
            }

            CargarDatos();
        }

        private void btnDescargarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "PDF (*.pdf)|*.pdf",
                    FileName = $"ReporteDashboard_{DateTime.Now:yyyyMMddHHss}.pdf"
                };

                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    ExportarPDF(filePath);
                    MessageBox.Show("Reporte exportado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportarPDF(string filePath)
        {
            string tempPeliculasChart = Path.GetTempFileName() + ".png";
            string tempOcupacionChart = Path.GetTempFileName() + ".png";
            string tempMembresiasChart = Path.GetTempFileName() + ".png";

            try
            {
                Document doc = new Document(PageSize.A4);
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                doc.Open();

                Paragraph title = new Paragraph("Reporte Dashboard", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA,
                    18, iTextSharp.text.Font.BOLD));
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);
                doc.Add(new Paragraph(" "));

                Paragraph periodo = new Paragraph($"Periodo desde: {dtpFechaDesde.Value:dd/MM/yyyy} - hasta: {dtpFechaHasta.Value:dd/MM/yyyy}",
                    new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12));
                doc.Add(periodo);
                doc.Add(new Paragraph(" "));

                Paragraph resumen = new Paragraph("Resumen General", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA,
                    16, iTextSharp.text.Font.BOLD));
                doc.Add(resumen);
                doc.Add(new Paragraph(" "));

                PdfPTable tablaResumen = new PdfPTable(2);
                tablaResumen.WidthPercentage = 80;
                tablaResumen.SetWidths(new float[] { 1, 1 });

                tablaResumen.AddCell("Boletos Vendidos");
                tablaResumen.AddCell(lblBoletosVendidos.Text);

                tablaResumen.AddCell("Membresias Activas");
                tablaResumen.AddCell(lblNuevasMembresias.Text);

                tablaResumen.AddCell("Total Recaudado");
                tablaResumen.AddCell(lblTotalRecaudado.Text);

                doc.Add(tablaResumen);
                doc.Add(new Paragraph(" "));

                Paragraph graficos = new Paragraph("GRÁFICOS",
                    new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD));
                doc.Add(graficos);
                doc.Add(new Paragraph(" "));

                chartPeliculas.SaveImage(tempPeliculasChart, ChartImageFormat.Png);
                chartOcupacion.SaveImage(tempOcupacionChart, ChartImageFormat.Png);
                chartTotalMembresias.SaveImage(tempMembresiasChart, ChartImageFormat.Png);

                doc.Add(new Paragraph("Películas más vistas - Cantidad de boletos vendidos",
                    new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD)));
                iTextSharp.text.Image imagenPeliculas = iTextSharp.text.Image.GetInstance(tempPeliculasChart);
                imagenPeliculas.ScalePercent(75);
                doc.Add(imagenPeliculas);
                doc.Add(new Paragraph(" "));

                doc.Add(new Paragraph("Porcentaje de ocupación de salas",
                    new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD)));
                iTextSharp.text.Image imagenOcupacion = iTextSharp.text.Image.GetInstance(tempOcupacionChart);
                imagenOcupacion.ScalePercent(75);
                doc.Add(imagenOcupacion);
                doc.Add(new Paragraph(" "));

                doc.Add(new Paragraph("Membresias activas por tipo", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA,
                                                                         12, iTextSharp.text.Font.BOLD)));
                iTextSharp.text.Image imagenMembresias = iTextSharp.text.Image.GetInstance(tempMembresiasChart);
                imagenMembresias.ScalePercent(75);
                doc.Add(imagenMembresias);
                doc.Add(new Paragraph(" "));

                Paragraph productos = new Paragraph("PRODUCTOS CON BAJO STOCK",
                    new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD));
                doc.Add(productos);
                doc.Add(new Paragraph(" "));

                PdfPTable tablaProductos = new PdfPTable(3);
                tablaProductos.WidthPercentage = 100;
                tablaProductos.SetWidths(new float[] { 2, 4, 1 });

                tablaProductos.AddCell(new PdfPCell(new Phrase("Nombre", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD))));
                tablaProductos.AddCell(new PdfPCell(new Phrase("Descripción", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD))));
                tablaProductos.AddCell(new PdfPCell(new Phrase("Stock", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD))));

                var productosLowStock = _gestorProducto.ConsultarConStockBajo();
                foreach (var producto in productosLowStock)
                {
                    tablaProductos.AddCell(producto.NombreProducto);
                    tablaProductos.AddCell(producto.DescripcionProducto);
                    tablaProductos.AddCell(producto.Stock.ToString());
                }

                doc.Add(tablaProductos);

                doc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                try
                {
                    if (File.Exists(tempPeliculasChart))
                        File.Delete(tempPeliculasChart);
                    if (File.Exists(tempOcupacionChart))
                        File.Delete(tempOcupacionChart);
                    if (File.Exists(tempMembresiasChart))
                        File.Delete(tempMembresiasChart);
                }
                catch { }
            }
        }

        private void btnHoy_Click(object sender, EventArgs e)
        {
            dtpFechaDesde.Value = DateTime.Today;
            dtpFechaHasta.Value = DateTime.Today;

            CargarDatos();
            CargarProductosBajoStock();
        }

        private void btnSemana_Click(object sender, EventArgs e)
        {
            dtpFechaHasta.Value = DateTime.Today;
            dtpFechaDesde.Value = DateTime.Today.AddDays(-7);

            CargarDatos();
            CargarProductosBajoStock();
        }

        private void btn30Dias_Click(object sender, EventArgs e)
        {
            dtpFechaHasta.Value = DateTime.Today;
            dtpFechaDesde.Value = DateTime.Today.AddDays(-30);

            CargarDatos();
            CargarProductosBajoStock();
        }

        private void btnMes_Click(object sender, EventArgs e)
        {
            DateTime firstDayOfMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpFechaDesde.Value = firstDayOfMonth;
            dtpFechaHasta.Value = DateTime.Today;

            CargarDatos();
            CargarProductosBajoStock();
        }
    }
}

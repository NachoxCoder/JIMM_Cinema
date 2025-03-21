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
using Servicios;

namespace JIMM_Cinema
{
    public partial class Fr_Dashboard: Form
    {
        private readonly BLL_Dashboard _gestorDashboard;
        private readonly BLL_Producto _gestorProducto;
        private readonly GeneradorPDF _generadorPDF;
        private string tempPeliculasChart;
        private string tempOcupacionChart;
        private string tempMembresiasChart;
        private string tempAnalisisIngresosChart;
        public Fr_Dashboard()
        {
            InitializeComponent();
            _gestorDashboard = new BLL_Dashboard();
            _gestorProducto = new BLL_Producto();
            _generadorPDF = new GeneradorPDF();
            dtpFechaDesde.Value = DateTime.Today.AddMonths(-1);
            dtpFechaHasta.Value = DateTime.Today;
            tempPeliculasChart = "tempPeliculasChart.png";
            tempOcupacionChart = "tempOcupacionChart.png";
            tempMembresiasChart = "tempMembresiasChart.png";
            tempAnalisisIngresosChart = "tempAnalisisIngresosChart.png";
        }

        private void Fr_Dashboard_Load(object sender, EventArgs e)
        {
            ConfigurarGraficos();
            CargarDatos();
            CargarProductosBajoStock();
        }

        private void ConfigurarGraficos()
        {
            //Grafico de peliculas mas vistas
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

            //Grafico de ocupacion de salas
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

            //Grafico de membresias activas
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

            //Grafico de analisis de ingresos
            chartAnalisisIngresos.Series.Clear();
            chartAnalisisIngresos.Palette = ChartColorPalette.Fire;
            chartAnalisisIngresos.BackColor = Color.WhiteSmoke;
            chartAnalisisIngresos.BorderlineColor = Color.LightGray;
            chartAnalisisIngresos.BorderlineDashStyle = ChartDashStyle.Solid;
            chartAnalisisIngresos.BorderlineWidth = 1;

            var serieIngresos = new Series("Ingresos Diarios")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 3,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 8,
                Font = new System.Drawing.Font("Segoe UI", 9, FontStyle.Bold),
                Color = Color.Red
            };
            chartAnalisisIngresos.Series.Add(serieIngresos);

            chartAnalisisIngresos.ChartAreas[0].BackColor = Color.White;
            chartAnalisisIngresos.ChartAreas[0].BorderColor = Color.LightGray;
            chartAnalisisIngresos.ChartAreas[0].BorderWidth = 1;
            chartAnalisisIngresos.ChartAreas[0].AxisX.Title = "Fecha";
            chartAnalisisIngresos.ChartAreas[0].AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 8, FontStyle.Bold);
            chartAnalisisIngresos.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 6);
            chartAnalisisIngresos.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            chartAnalisisIngresos.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chartAnalisisIngresos.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM";
            chartAnalisisIngresos.ChartAreas[0].AxisX.Interval = 1;
            chartAnalisisIngresos.ChartAreas[0].AxisY.Title = "Ingresos ($)";
            chartAnalisisIngresos.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("Segoe UI", 8, FontStyle.Bold);
            chartAnalisisIngresos.ChartAreas[0].AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8);
            chartAnalisisIngresos.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chartAnalisisIngresos.ChartAreas[0].AxisY.LabelStyle.Format = "${0:N0}";
            chartAnalisisIngresos.Legends[0].Docking = Docking.Bottom;

            chartAnalisisIngresos.Titles.Clear();
            var title = new Title("Tendencia de Ingresos", Docking.Top, new System.Drawing.Font("Segoe UI", 8, FontStyle.Bold), Color.Black);
            chartAnalisisIngresos.Titles.Add(title);
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
                    $"${Convert.ToDecimal(datosGenerales["VentasPeriodo"]):N0}" : "$0";

                //Grafico de peliculas mas vistas
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

                //Grafico de ocupacion de salas
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

                //Grafico de analisis de ingresos
                var tendenciaIngresos = _gestorDashboard.ObtenerIngresosDiarios(dtpFechaDesde.Value, dtpFechaHasta.Value);

                chartAnalisisIngresos.Series[0].Points.Clear();

                //Declaramos una variable para almacenar la cantidad de dias de diferencia entre las fechas
                int diasDiferencia = (int)(dtpFechaHasta.Value - dtpFechaDesde.Value).TotalDays;

                //Establecer el intervalo del eje X en base a la cantidad de dias de diferencia entre las fechas
                //Si la diferencia es mayor a 14 dias, establecemos un intervalo de 10 dias, sino, intervalo de 1 dia
                if (diasDiferencia > 14)
                {
                    //Si el rango de fechas es de 30 días (diasDiferencia = 30), el intervalo del eje X será 30 / 10 = 3 días.
                    chartAnalisisIngresos.ChartAreas[0].AxisX.Interval = Math.Max(1, diasDiferencia / 10);
                }
                else
                {
                    chartAnalisisIngresos.ChartAreas[0].AxisX.Interval = 1;
                }

                //Recorremos el diccionario de tendencia de ingresos y agregamos los puntos al grafico
                foreach (var item in tendenciaIngresos)
                {
                    //Por cada item en el diccionario agregamos un punto al grafico con la fecha y el monto de ingresos
                    int pointIndex = chartAnalisisIngresos.Series[0].Points.AddXY(item.Key, item.Value);
                    var point = chartAnalisisIngresos.Series[0].Points[pointIndex];
                    point.ToolTip = $"{item.Key:dd/MM}: ${item.Value:N2}";
                }

                //Si hay valores en la tendencia de ingresos, calculamos estadisticas(Min,Max, Promedio, Total)
                var valores = tendenciaIngresos.Values.ToList();
                if(valores.Any())
                {
                    decimal min = valores.Min();
                    decimal max = valores.Max();
                    decimal promedio = valores.Average();
                    decimal total = valores.Sum();

                    //Almacenamos las estadisticas en un string
                    string estadisticas = $"Min: ${min:N0} | Max: ${max:N0} | Promedio: ${promedio:N0} | Total: ${total:N0}";

                    //Agregamos un titulo con las estadisticas, y nos aseguramos que a medida que el grafico se actualiza, se actualice el Titulo
                    //Para ello revisamos si el grafico tiene 2 titulos, si es asi, actualizamos el segundo titulo, sino, lo creamos
                    if (chartAnalisisIngresos.Titles.Count < 2)
                    {
                        var estadisticasTitulo = new Title(estadisticas, Docking.Bottom, 
                            new System.Drawing.Font("Segoe UI", 9, FontStyle.Bold), Color.Black);
                        chartAnalisisIngresos.Titles.Add(estadisticasTitulo);
                    }
                    else
                    {
                        chartAnalisisIngresos.Titles[1].Text = estadisticas;
                    }
                }

                //Utilizamos el metodo Invalidate para que se actualicen los graficos cada vez que el usuario cambie la fecha
                chartPeliculas.Invalidate();
                chartOcupacion.Invalidate();
                chartTotalMembresias.Invalidate();
                chartAnalisisIngresos.Invalidate();
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

        //Metodo para exportar el reporte a PDF
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

                    var datosGenerales = _gestorDashboard.ObtenerDatos(dtpFechaDesde.Value, dtpFechaHasta.Value);
                    var datosPeliculas = _gestorDashboard.ObtenerDatosPeliculas(dtpFechaDesde.Value, dtpFechaHasta.Value);
                    var datosOcupacion = _gestorDashboard.ObtenerDatosOcupacion(dtpFechaDesde.Value, dtpFechaHasta.Value);
                    var datosMembresias = _gestorDashboard.ObtenerMembresiasActivasPorTipo();
                    var productosLowStock = _gestorProducto.ConsultarConStockBajo();

                    chartPeliculas.SaveImage(tempPeliculasChart, ChartImageFormat.Png);
                    chartOcupacion.SaveImage(tempOcupacionChart, ChartImageFormat.Png);
                    chartTotalMembresias.SaveImage(tempMembresiasChart, ChartImageFormat.Png);
                    chartAnalisisIngresos.SaveImage(tempAnalisisIngresosChart, ChartImageFormat.Png);

                    string pdfPath = _generadorPDF.GenerarReporteDashboard( datosGenerales, datosPeliculas, datosOcupacion, 
                                    datosMembresias, productosLowStock, dtpFechaDesde.Value, dtpFechaHasta.Value, filePath);

                    MessageBox.Show("Reporte exportado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                try
                {
                    if (File.Exists(tempPeliculasChart)) File.Delete(tempPeliculasChart);
                    if (File.Exists(tempOcupacionChart)) File.Delete(tempOcupacionChart);
                    if (File.Exists(tempMembresiasChart)) File.Delete(tempMembresiasChart);
                    if (File.Exists(tempAnalisisIngresosChart)) File.Delete(tempAnalisisIngresosChart);
                }
                catch { }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

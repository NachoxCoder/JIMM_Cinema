using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Dashboard
    {
        private readonly BLL_Boleto _gestorBoleto;
        private readonly BLL_Cliente _gestorCliente;
        private readonly BLL_Membresia _gestorMembresia;
        private readonly BLL_Producto _gestorProducto;
        private readonly BLL_Pelicula _gestorPelicula;
        private readonly BLL_Sala _gestorSala;
        private readonly BLL_Funcion _gestorFuncion;

        public BLL_Dashboard()
        {
            _gestorBoleto = new BLL_Boleto();
            _gestorCliente = new BLL_Cliente();
            _gestorMembresia = new BLL_Membresia();
            _gestorProducto = new BLL_Producto();
            _gestorPelicula = new BLL_Pelicula();
            _gestorSala = new BLL_Sala();
            _gestorFuncion = new BLL_Funcion();
        }

        public Dictionary<string, object> ObtenerDatos()
        {
            var datos = new Dictionary<string, object>();

            datos["TotalClientes"] = _gestorCliente.Consultar().Count;
            datos["TotalMembresiasActivas"] = _gestorMembresia.Consultar().Count(x => x.EstaActiva);
            var boletosHoy = _gestorBoleto.Consultar().Where(x => x.FechaVenta.Date == DateTime.Today).ToList();
            datos["VentasHoy"] = boletosHoy.Sum(x => x.Precio);
            var boletosMes = _gestorBoleto.Consultar().Where(x => x.FechaVenta.Date >= DateTime.Today.AddMonths(-1) 
                                                            && x.FechaVenta.Date <= DateTime.Today).ToList();
            datos["VentasMes"] = boletosMes.Sum(x => x.Precio);

            return datos;
        }

        public Dictionary<string, decimal> ObtenerDatosPorPeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            var datos = new Dictionary<string, decimal>();

            var boletos = _gestorBoleto.Consultar().Where(x => x.FechaVenta.Date >= fechaDesde.Date 
                && x.FechaVenta.Date <= fechaHasta.Date)
                .GroupBy(x => x.FechaVenta.Date).Select(x => new { Fecha = x.Key, Total = x.Sum(y => y.Precio) })
                .OrderBy(x => x.Fecha).ToList();

            for(var date = fechaDesde.Date; date <= fechaHasta.Date; date = date.AddDays(1))
            {
                string dateKey = date.ToString("MM/dd");
                datos[dateKey] = 0;
            }

            foreach (var item in boletos)
            {
                string dateKey = item.Fecha.ToString("MM/dd");
                datos[dateKey] = item.Total;
            }

            return datos;
        }

        public Dictionary<string, double> ObtenerDatosPeliculas()
        {
            var datos = new Dictionary<string, double>();

            var peliculas = _gestorBoleto.Consultar().GroupBy(x => x.Funcion.Pelicula.Titulo)
                .Select(x => new { Pelicula = x.Key, Cantidad = x.Count() })
                .OrderByDescending(x => x.Cantidad).Take(5).ToList();

            foreach (var item in peliculas)
            {
                datos[item.Pelicula] = item.Cantidad;
            }

            return datos;
        }

        public Dictionary<string, double> ObtenerDatosOcupacion()
        {
            var datos = new Dictionary<string, double>();
            var boletos = _gestorBoleto.Consultar();
            var salas = _gestorSala.Consultar();

            foreach (var item in salas)
            {
                var funcionesSala = _gestorFuncion.Consultar().Where(x => x.Sala.ID == item.ID).ToList();
                if(funcionesSala.Count == 0) continue;

                int totalCapacidad = funcionesSala.Sum(x => x.Sala.Capacidad);
                int butacasOcupadas = boletos.Count(x => funcionesSala.Any(y => y.ID == x.Funcion.ID));

                double porcentajeOcupacion = totalCapacidad > 0 ? (double)butacasOcupadas / totalCapacidad * 100 : 0;

                datos[item.Nombre] = Math.Round(porcentajeOcupacion, 1);
            }

            return datos;
        }

        public void ExportarReporte(string filePath, DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                using (var fs = new FileStream(filePath, FileMode.Create))
                {
                    using (var writer = new StreamWriter(fs, Encoding.UTF8))
                    {
                        // Simple text-based export as a fallback without iTextSharp dependency
                        writer.WriteLine("REPORTE DE MÉTRICAS DE CINE");
                        writer.WriteLine($"Período: {fechaDesde:dd/MM/yyyy} - {fechaHasta:dd/MM/yyyy}");
                        writer.WriteLine();

                        var metrics = ObtenerDatos();
                        writer.WriteLine("MÉTRICAS GENERALES");
                        writer.WriteLine($"Total Clientes: {metrics["TotalClientes"]}");
                        writer.WriteLine($"Membresías Activas: {metrics["MembresiasActivas"]}");
                        writer.WriteLine($"Ventas del Día: $ {metrics["VentasHoy"]:N2}");
                        writer.WriteLine($"Ventas del Período: $ {metrics["VentasMes"]:N2}");
                        writer.WriteLine();

                        writer.WriteLine("PELÍCULAS MÁS VISTAS");
                        foreach (var pelicula in ObtenerDatosPeliculas())
                        {
                            writer.WriteLine($"{pelicula.Key}: {pelicula.Value} tickets");
                        }
                        writer.WriteLine();

                        writer.WriteLine("OCUPACIÓN POR SALAS");
                        foreach (var sala in ObtenerDatosOcupacion())
                        {
                            writer.WriteLine($"{sala.Key}: {sala.Value:N1}%");
                        }
                        writer.WriteLine();

                        writer.WriteLine("PRODUCTOS CON STOCK BAJO");
                        foreach (var producto in _gestorProducto.ConsultarConStockBajo())
                        {
                            writer.WriteLine($"{producto.NombreProducto}: {producto.Stock} unidades");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al exportar reporte: {ex.Message}", ex);
            }
        }
    }
}

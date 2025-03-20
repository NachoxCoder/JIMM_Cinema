using BE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Dashboard
    {
        private readonly BLL_Boleto _gestorBoleto;
        private readonly BLL_Cliente _gestorCliente;
        private readonly BLL_Membresia _gestorMembresia;
        private readonly BLL_Sala _gestorSala;
        private readonly BLL_Funcion _gestorFuncion;

        public BLL_Dashboard()
        {
            _gestorBoleto = new BLL_Boleto();
            _gestorCliente = new BLL_Cliente();
            _gestorMembresia = new BLL_Membresia();
            _gestorSala = new BLL_Sala();
            _gestorFuncion = new BLL_Funcion();
        }

        public Dictionary<string, object> ObtenerDatos(DateTime? fechaDesde = null, DateTime? fechaHasta = null)
        {
            var datos = new Dictionary<string, object>();

            fechaDesde = fechaDesde ?? DateTime.Today.AddMonths(-1);
            fechaHasta = fechaHasta ?? DateTime.Today;

            var boletos = _gestorBoleto.Consultar();
            var boletosPeriodo = boletos.Where(x => x.FechaVenta.Date >= fechaDesde.Value.Date 
                                               && x.FechaVenta.Date <= fechaHasta.Value.Date).ToList();

            datos["TotalClientes"] = _gestorCliente.Consultar().Count;
            datos["TotalMembresiasActivas"] = _gestorMembresia.Consultar().Count(x => x.EstaActiva);
            datos["NuevasMembresias"] = _gestorMembresia.Consultar().Count(x => x.FechaInicio >= fechaDesde.Value 
                                        && x.FechaInicio <= fechaHasta.Value);
            datos["BoletosVendidosPeriodo"] = boletosPeriodo.Count;
            datos["VentasPeriodo"] = boletosPeriodo.Sum(x => x.Precio);
            datos["TotalTicketsVendidos"] = boletos.Count;
            datos["VentasHoy"] = boletos.Where(x => x.FechaVenta.Date == DateTime.Today.Date).Sum(x => x.Precio);
            datos["VentasMes"] = boletos.Where(x => x.FechaVenta.Month == DateTime.Today.Month
                                    && x.FechaVenta.Year == DateTime.Today.Year).Sum(x => x.Precio);

            return datos;
        }

        public Dictionary<string, int> ObtenerDatosPeliculas(DateTime fechaDesde, DateTime fechaHasta)
        {
            var datos = new Dictionary<string, int>();

            var boletos = _gestorBoleto.Consultar().Where(x => x.FechaVenta.Date >= fechaDesde.Date
                        && x.FechaVenta.Date <= fechaHasta.Date);

            if (!boletos.Any()) return datos;

            var peliculas = boletos.GroupBy(x => x.Funcion?.Pelicula?.Titulo ?? "Sin Titulo")
                .Select(x => new { Pelicula = x.Key, ButacasVendidas = x.Sum(b => b.Butacas.Count) })
                .OrderByDescending(x => x.ButacasVendidas).Take(5).ToList();

            foreach (var item in peliculas)
            {
                datos[item.Pelicula] = item.ButacasVendidas;
            }

            return datos;
        }

        public Dictionary<string, double> ObtenerDatosOcupacion(DateTime fechaDesde, DateTime fechaHasta)
        {
            var datos = new Dictionary<string, double>();

            try
            {
                var boletos = _gestorBoleto.Consultar()
                    .Where(b => b.FechaVenta.Date >= fechaDesde.Date &&
                                b.FechaVenta.Date <= fechaHasta.Date)
                    .ToList();

                if (!boletos.Any())
                {
                    datos["Sin Datos"] = 100;
                    return datos;
                }

                var boletosPorSala = boletos.Where(b => b.Funcion != null && b.Funcion.Sala != null).GroupBy(b => b.Funcion.Sala.Nombre)
                    .ToDictionary( g => g.Key,g => g.Sum(b => b.Butacas?.Count ?? 0));

                int totalButacasVendidas = boletosPorSala.Sum(kvp => kvp.Value);

                if (totalButacasVendidas == 0)
                {
                    datos["Sin Datos"] = 100;
                    return datos;
                }

                foreach (var kvp in boletosPorSala)
                {
                    double porcentaje = ((double)kvp.Value / totalButacasVendidas) * 100;
                    datos[kvp.Key] = Math.Round(porcentaje, 1);
                }

                return datos;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in ObtenerDatosOcupacion: {ex.Message}");

                datos["Sin Datos"] = 100;
                return datos;
            }
        }

        public Dictionary<string, int> ObtenerMembresiasActivasPorTipo()
        {
            var datos = new Dictionary<string, int>();

            var membresiasActivas = _gestorMembresia.Consultar().Where(x => x.EstaActiva);

            foreach(TipoMembresia tipo in Enum.GetValues(typeof(TipoMembresia)))
            {
                string tipoNombre = tipo.ToString();
                int cantidad = membresiasActivas.Count(x => x.Tipo == tipo);
                datos[tipoNombre] = cantidad;
            }

            return datos;
        }

        public Dictionary<DateTime, decimal> ObtenerIngresosDiarios(DateTime startDate, DateTime endDate)
        {
            var boletos = _gestorBoleto.Consultar().Where(b => b.FechaVenta.Date >= startDate.Date
                                                          && b.FechaVenta.Date <= endDate.Date).ToList();

            var ingresosPorDia = boletos.GroupBy(b => b.FechaVenta.Date).OrderBy(g => g.Key).ToDictionary(g => g.Key,
                    g => g.Sum(b => b.Precio));

            for (var fecha = startDate.Date; fecha <= endDate.Date; fecha = fecha.AddDays(1))
            {
                if (!ingresosPorDia.ContainsKey(fecha))
                {
                    ingresosPorDia[fecha] = 0;
                }
            }

            return ingresosPorDia.OrderBy(kvp => kvp.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace BE
{
    public class BE_Funcion
    {
        public BE_Funcion() 
        { 
            Boletos = new List<BE_Boleto>();
            EstaActiva = true;
        }

        [Browsable(false)]
        public int ID { get; set; }
        public DateTime FechaFuncion { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public bool EstaActiva { get; set; }
        public decimal Precio { get; set; }
        public BE_Pelicula Pelicula { get; set; }
        public BE_Sala Sala { get; set; }
        public List<BE_Boleto> Boletos { get; set; }

        public string PeliculaTitulo ()
        {
            return Pelicula?.Titulo?? "No hay pelicula asignada";
        }
        public string SalaNombre()
        {
            return Sala?.Nombre ?? "No hay sala asignada";
        }
        public int AsientosDisponibles()
        {
            int totalCapacidadSala = Sala?.Capacidad?? 0;
            int boletosVendidos = Boletos?.Count?? 0;
            return totalCapacidadSala - boletosVendidos;
        }

        public bool SeSolapaCon(BE_Funcion otraFuncion)
        {
            if (FechaFuncion.Date != otraFuncion.FechaFuncion.Date ||
                Sala.ID != otraFuncion.Sala.ID ||
                !EstaActiva ||
                !otraFuncion.EstaActiva)
            {
                return false;
            }

            DateTime inicioThis = FechaFuncion.Date.Add(HoraInicio);
            DateTime finThis = FechaFuncion.Date.Add(HoraFin);
            DateTime inicioOtra = otraFuncion.FechaFuncion.Date.Add(otraFuncion.HoraInicio);
            DateTime finOtra = otraFuncion.FechaFuncion.Date.Add(otraFuncion.HoraFin);

            return (inicioThis < finOtra && finThis > inicioOtra);
        }
    }
}

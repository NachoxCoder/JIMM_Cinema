using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Sala
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Capacidad { get; set; }
        public bool Tiene3D { get; set; }
        public List<BE_Funcion> Funciones { get; set; }
        public List<BE_Butaca> Butacas { get; set; }

        public BE_Sala()
        {
            Funciones = new List<BE_Funcion>();
            Butacas = new List<BE_Butaca>();
        }
    }
}

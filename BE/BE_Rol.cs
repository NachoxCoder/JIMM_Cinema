using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Rol : BE_Componente
    {
        public List<BE_Componente> Hijos { get; set; }

        public BE_Rol(string pNombre) : base(pNombre)
        {
            EsRol = true;
            Hijos = new List<BE_Componente>();
        }

        public BE_Rol()
        {
            EsRol = true;
            Hijos = new List<BE_Componente>();
        }

        public override void AgregarHijo(BE_Componente pComponente)
        {
            if(!Hijos.Contains(pComponente))
                Hijos.Add(pComponente);
        }

        public override List<BE_Componente> ObtenerHijos()
        {
            List<BE_Componente> listaComponentes = new List<BE_Componente>();
            foreach (BE_Componente componente in Hijos)
            {
                if (componente is BE_Rol rol)
                {
                    listaComponentes.AddRange(rol.ObtenerHijos());
                }
                else
                {
                    listaComponentes.Add(componente);
                }
            }
            return listaComponentes;
        }

        public override void RemoverHijo(BE_Componente pComponent)
        {
            Hijos.Remove(pComponent);
        }

        public override void QuitarTodosHijos()
        {
            Hijos.Clear();
        }
    }
}

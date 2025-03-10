using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Rol : BE_Componente
    {
        private readonly List<BE_Componente> _hijos;

        public BE_Rol(string pNombre) : base(pNombre)
        {
            EsRol = true;
            _hijos = new List<BE_Componente>();
        }

        public BE_Rol()
        {
                    
        }

        public override void AgregarHijo(BE_Componente pComponente)
        {
            if(!_hijos.Contains(pComponente))
                _hijos.Add(pComponente);
        }

        public override List<BE_Componente> ObtenerHijos()
        {
            List<BE_Componente> listaComponentes = new List<BE_Componente>();
            foreach (BE_Componente componente in _hijos)
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
            _hijos.Remove(pComponent);
        }

        public override void QuitarTodosHijos()
        {
            _hijos.Clear();
        }
    }
}

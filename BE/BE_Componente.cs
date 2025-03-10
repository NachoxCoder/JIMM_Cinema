using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BE
{
    [XmlInclude(typeof(BE_Rol))]
    [XmlInclude(typeof(BE_Permiso))]
    public abstract class BE_Componente
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public bool EsRol { get; set; }

        protected BE_Componente(string pNombre)
        {
            Nombre = pNombre;
        }

        protected BE_Componente()
        {
                
        }

        //Metodos abstractos pra implementar el patron Composite
        public abstract List<BE_Componente> ObtenerHijos();
        public abstract void AgregarHijo(BE_Componente pComponent);
        public abstract void RemoverHijo(BE_Componente pComponent);
        public abstract void QuitarTodosHijos();

        public override string ToString()
        {
            return Nombre;
        }

        //Metodo para comparar componentes
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            BE_Componente otro = (BE_Componente)obj;
            return ID == otro.ID && Nombre == otro.Nombre;
        }

        /*
        public override int GetHashCode()
        {
            return HashCode.Combine(ID, Nombre);
        }*/
    }
}

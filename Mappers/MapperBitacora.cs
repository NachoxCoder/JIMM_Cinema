using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace Mappers
{
    public class MapperBitacora
    {
        private readonly DAL_Xml dAL_Xml;

        public MapperBitacora()
        {
            dAL_Xml = new DAL_Xml();
        }

        public void Alta(BE_Bitacora bitacora)
        {
            var bitacoras = dAL_Xml.LeerXml<BE_Bitacora>();
            bitacora.ID = bitacoras.Any() ? bitacoras.Max(x => x.ID) + 1 : 1;
            bitacoras.Add(bitacora);
            dAL_Xml.GuardarXml(bitacoras);
        }

        public List<BE_Bitacora> Consultar()
        {
            return dAL_Xml.LeerXml<BE_Bitacora>();
        }

        public BE_Bitacora ConsultarPorID(int id)
        {
            return Consultar().FirstOrDefault(x => x.ID == id);
        }
    }
}

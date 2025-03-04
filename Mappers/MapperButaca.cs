using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace Mappers
{
    public class MapperButaca
    {
        private readonly DAL_Xml _dalXml;

        public MapperButaca()
        {
            _dalXml = new DAL_Xml();
        }

        public void Alta(BE.BE_Butaca butaca)
        {
            var butacas = _dalXml.LeerXml<BE_Butaca>();
            butaca.ID = butacas.Any() ? butacas.Max(x => x.ID) + 1 : 1;
            butacas.Add(butaca);
            _dalXml.GuardarXml(butacas);
        }

        public void Baja(BE.BE_Butaca butaca)
        {
            var butacas = _dalXml.LeerXml<BE_Butaca>();
            var butacaEncontrada = butacas.Find(x => x.ID == butaca.ID);
            butacas.Remove(butacaEncontrada);
            _dalXml.GuardarXml(butacas);
        }

        public void Modificar(BE_Butaca butaca)
        {
            var butacas = _dalXml.LeerXml<BE_Butaca>();
            var butacaEncontrada = butacas.Find(x => x.ID == butaca.ID);
            if(butacaEncontrada != null)
            {
                butacaEncontrada.Fila = butaca.Fila;
                butacaEncontrada.Numero = butaca.Numero;
                butacaEncontrada.Disponible = butaca.Disponible;
                butacaEncontrada.Sala = butaca.Sala;
                _dalXml.GuardarXml(butacas);
            }
        }

        public List<BE_Butaca> Consultar()
        {
            return _dalXml.LeerXml<BE_Butaca>();
        }

        public void OcuparButaca(int idButaca, int idFuncion)
        {
            var butacas = _dalXml.LeerXml<BE_Butaca>();
            var butaca = butacas.First(x => x.ID == idButaca);
            butaca.Disponible = false;
            _dalXml.GuardarXml(butacas);
        }

        public BE_Butaca ObtenerPorId(int id)
        {
            return Consultar().FirstOrDefault(x => x.ID == id);
        }

        public BE_Butaca ObtenerPorUbicacion(int idSala, string fila, int numero)
        {
            return Consultar().FirstOrDefault(x => x.Sala.ID == idSala && x.Fila == fila && x.Numero == numero);
        }
    }
}

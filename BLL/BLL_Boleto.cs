using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mappers;
using BE;

namespace BLL
{
    public class BLL_Boleto
    {
        private readonly MapperBoleto _mapperBoleto;

        public BLL_Boleto()
        {
            _mapperBoleto = new MapperBoleto();
        }

        public void Alta(BE_Boleto boleto)
        {
            _mapperBoleto.Alta(boleto);
        }

        public List<BE_Boleto> Consultar()
        {
            return _mapperBoleto.Consultar();
        }
    }
}

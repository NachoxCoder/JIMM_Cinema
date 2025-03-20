using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mappers;
using BE;
using Servicios;

namespace BLL
{
    public class BLL_Boleto
    {
        private readonly MapperBoleto _mapperBoleto;
        private readonly GeneradorPDF _generadorPDF;

        public BLL_Boleto()
        {
            _mapperBoleto = new MapperBoleto();
            _generadorPDF = new GeneradorPDF();
        }

        public void Alta(BE_Boleto boleto)
        {
            _mapperBoleto.Alta(boleto);

            string pdfPath = _generadorPDF.GenerarBoletoPDF(boleto);
        }

        public List<BE_Boleto> Consultar()
        {
            return _mapperBoleto.Consultar();
        }
    }
}

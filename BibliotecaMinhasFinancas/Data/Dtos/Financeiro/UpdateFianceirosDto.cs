using BibliotecaMinhasFinancas.Data.Dtos.Saldo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMinhasFinancas.Data.Dtos.Gastos
{
    public class UpdateFianceirosDto
    {
        public int Ano { get; set; }
        public int Mes { get; set; }
        public double ValorDocumento { get; set; }
        public int AnoAntigo { get; set; }
        public int MesAntigo { get; set; }
        public double ValorDocumentoAntigo { get; set; }
        public TipoOperacao TipoOperacao { get; set; }
        public TipoDocumento tipoDocumento {  get; set; }
    }
}

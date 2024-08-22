using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMinhasFinancas.Data.Dtos.Saldo
{
    public enum TipoDocumento
    {
        Entrada = 1,
        Saida = 2
    }
    public enum TipoOperacao
    {
        Inserir = 1,
        Alterar = 2,
        Deletar = 3
    }
    public class SaldoDto
    {
        public double ValorDocumentoAntigo { get; set; }
        public double ValorDocumento { get; set; }
        public TipoOperacao TipoOperacao { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
    }
}

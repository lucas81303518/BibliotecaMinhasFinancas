using BibliotecaMinhasFinancas.Data.Dtos.Documentos;
using System.ComponentModel.DataAnnotations;

namespace BibliotecaMinhasFinancas.Data.Dtos.FormasPagamento
{
    public class ReadFormaPagamentoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
    }
}

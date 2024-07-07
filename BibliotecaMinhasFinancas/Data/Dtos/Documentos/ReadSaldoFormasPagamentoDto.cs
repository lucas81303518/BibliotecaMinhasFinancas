using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BibliotecaMinhasFinancas.Models;

namespace BibliotecaMinhasFinancas.Data.Dtos.Documentos
{
    public class ReadSaldoFormasPagamentoDto
    {
        public double Valor { get; set; }
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}

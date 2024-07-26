using System.ComponentModel.DataAnnotations;

namespace BibliotecaMinhasFinancas.Data.Dtos.FormasPagamento
{
    public class UpdateFormasPagamentoDto
    {
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo Valor é obrigatório!")]
        public double Valor { get; set; }
        [Required]
        public int UsuarioId { get; set; }
    }
}

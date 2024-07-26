using System.ComponentModel.DataAnnotations;

namespace BibliotecaMinhasFinancas.Dtos.Transferencias
{
    public class UpdateTransferenciasDto
    {
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Campo Conta Origem é obrigatório!")]
        public int ContaOrigem { get; set; }
        [Required(ErrorMessage = "Campo Conta Destino é obrigatório!")]
        public int ContaDestino { get; set; }
        public DateTime DataTransferencia { get; set; }
        [Required(ErrorMessage = "Campo Valor é obrigatório!")]
        public double Valor { get; set; }
        [Required]
        public int UsuarioId { get; set; }
    }
}

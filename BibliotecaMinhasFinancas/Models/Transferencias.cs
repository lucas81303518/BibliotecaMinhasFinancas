using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibliotecaMinhasFinancas.Models
{
    public class Transferencias
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Descricao é obrigatório!")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Campo Conta Origem é obrigatório!")]
        public int ContaOrigem { get; set; }
        [Required(ErrorMessage = "Campo Conta Destino é obrigatório!")]
        public int ContaDestino { get; set; }
        public DateTimeOffset DataTransferencia { get; set; }
        [Required(ErrorMessage = "Campo Valor é obrigatório!")]
        public double Valor { get; set; }
    }
}

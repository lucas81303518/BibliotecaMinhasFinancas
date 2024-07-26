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
        public DateTime DataTransferencia { get; set; }
        [Required(ErrorMessage = "Campo Valor é obrigatório!")]
        public double Valor { get; set; }
        [Required]
        public int UsuarioId { get; set; }
        public virtual Usuarios Usuario { get; set; }
    }
}

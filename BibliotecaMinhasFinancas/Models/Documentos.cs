using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace BibliotecaMinhasFinancas.Models
{
    public class Documentos
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Numero do Documento é obrigatório!")]
        public string NumeroDocumento { get; set; }        
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Campo Valor do Documento é obrigatório!")]
        public double Valor { get; set; }
        [Required(ErrorMessage = "Campo Data do Documento é obrigatório!")]
        [Column(TypeName = "date")]
        public DateTime DataDocumento { get; set; }
        public int QtdParcelas { get; set; }
        [Required(ErrorMessage = "Campo Status do Documento é obrigatório!")]
        public string Status { get; set; }
        public int CodigoMeta { get; set; }
        [Required]
        public int FormaPagamentoId { get; set; }
        public virtual FormasPagamento FormaPagamento { get; set; }
        [Required]
        public int TipoContaId { get; set; }
        public virtual TipoContas TipoConta { get; set; }
        [Required]
        public int UsuarioId { get; set; }
        public virtual Usuarios Usuario { get; set; } 
    }
}

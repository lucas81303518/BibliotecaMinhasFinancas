using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BibliotecaMinhasFinancas.Data.Dtos.Documentos
{
    public class UpdateDocumentosDto
    {
        public string NumeroDocumento { get; set; }       
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Campo Valor do Documento é obrigatório!")]
        public double Valor { get; set; }
        [Required(ErrorMessage = "Campo Data do Documento é obrigatório!")]
        public DateTime DataDocumento { get; set; }
        public int QtdParcelas { get; set; }
        [Required(ErrorMessage = "Campo Status do Documento é obrigatório!")]
        public string Status { get; set; }
        public int CodigoMeta { get; set; }
        [Required]
        public int FormaPagamentoId { get; set; }
        [Required]
        public int TipoContaId { get; set; }
        [Required]
        public int UsuarioId { get; set; }
    }
}

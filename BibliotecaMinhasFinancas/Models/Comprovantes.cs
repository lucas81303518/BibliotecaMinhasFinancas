using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibliotecaMinhasFinancas.Models
{
    public class Comprovantes
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Titulo é obrigatório!")]        
        public string TituloArquivo { get; set; }
        [Required(ErrorMessage = "Campo Caminho é obrigatório!")]        
        public string CaminhoArquivo { get; set; }
        [Required(ErrorMessage = "Campo Tipo do Comprovante é obrigatório!")]        
        public string TipoComprovante { get; set; }
        [Required(ErrorMessage = "Documento é obrigatório!")]
        public int DocumentoId { get; set; }
        public virtual Documentos Documento { get; set; }
        [Required]
        public int UsuarioId { get; set; }
        public virtual Usuarios Usuario { get; set; }
    }
}

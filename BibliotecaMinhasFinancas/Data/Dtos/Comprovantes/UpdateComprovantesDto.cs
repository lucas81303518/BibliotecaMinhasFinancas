using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using BibliotecaMinhasFinancas.Data.Dtos.Documentos;

namespace BibliotecaMinhasFinancas.Data.Dtos.Comprovantes
{
    public class UpdateComprovantesDto
    {
        public string TituloArquivo { get; set; }
        [Required(ErrorMessage = "Campo Caminho é obrigatório!")]
        public string CaminhoArquivo { get; set; }
        [Required(ErrorMessage = "Campo Tipo do Comprovante é obrigatório!")]
        public string TipoComprovante { get; set; }
        public int DocumentoId { get; set; }
        [Required]
        public int UsuarioId { get; set; }       
    }
}

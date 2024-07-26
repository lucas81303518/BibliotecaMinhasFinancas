using System.ComponentModel.DataAnnotations;

namespace BibliotecaMinhasFinancas.Data.Dtos.TipoContas
{
    public class UpdateTipoContasDto
    {
        [Required(ErrorMessage = "Campo Nome da Conta é obrigatório!")]
        public string NomeConta { get; set; }
        [Required(ErrorMessage = "Campo Tipo da Conta é obrigatório!")]
        public int Tipo { get; set; }
        [Required]
        public int UsuarioId { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BibliotecaMinhasFinancas.Dtos.Usuarios
{
    public class CreateUsuarioDto
    {
        [Required(ErrorMessage = "Campo Nome Completo é obrigatório!")]
        public string NomeCompleto { get; set; }
        [Required(ErrorMessage = "Campo Nome é obrigatório!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Campo E-mail é obrigatório!")]
        public string Email { get; set; }    

        [Required(ErrorMessage = "Campo Senha é obrigatório!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Campo Repetir Senha é obrigatório!")]
        [Compare("Password")]
        public string RePassword { get; set; }
        [Required(ErrorMessage = "Campo Data de Nascimento!")]
        public DateTime DataNascimento { get; set; }
        [Required(ErrorMessage = "Campo Celular")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [MaxLength(1048576)]
        public string FotoBase64 { get; set; } = string.Empty;
    }
}

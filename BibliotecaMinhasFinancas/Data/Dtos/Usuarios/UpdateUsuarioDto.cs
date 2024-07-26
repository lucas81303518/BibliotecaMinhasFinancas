using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BibliotecaMinhasFinancas.Dtos.Usuarios
{
    public class UpdateUsuarioDto
    {       
        [Required(ErrorMessage = "Campo Nome é obrigatório!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Campo E-mail é obrigatório!")]
        public string Email { get; set; }    

        [Required(ErrorMessage = "Campo Senha é obrigatório!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string RePassword { get; set; }
        [Required]       
        public DateTime DataNascimento { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
    }
}

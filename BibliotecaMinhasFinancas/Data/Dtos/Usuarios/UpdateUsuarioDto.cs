using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BibliotecaMinhasFinancas.Dtos.Usuarios
{
    public class UpdateUsuarioDto
    {       
        [Required(ErrorMessage = "Campo Nome é obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo E-mail é obrigatório!")]
        public string Email { get; set; }

        private string _senha;

        [Required(ErrorMessage = "Campo Senha é obrigatório!")]
        [DataType(DataType.Password)]
        public string Senha
        {
            get { return _senha; }
            set { _senha = Utils.Utils.CalcularHashSHA256(value); }
        }
        [Required]
        [Compare("Senha")]
        public string ConfirmarSenha { get; set; }
    }
}

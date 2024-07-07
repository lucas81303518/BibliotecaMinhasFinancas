using System.ComponentModel.DataAnnotations;

namespace BibliotecaMinhasFinancas.Data.Dtos.Usuarios
{
    public class CredenciaisLogin
    {
        [Required(ErrorMessage = "Usuário é obrigatorio!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Senha é obrigatorio!")]
        private string _senha;
        public string Senha
        {
            get { return _senha; }
            set { _senha = Utils.Utils.CalcularHashSHA256(value); }
        }
    }

}

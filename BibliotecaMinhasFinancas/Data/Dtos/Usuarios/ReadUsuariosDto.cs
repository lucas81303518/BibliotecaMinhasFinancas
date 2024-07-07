using BibliotecaMinhasFinancas.Data.Dtos.Documentos;
using System.ComponentModel.DataAnnotations;

namespace BibliotecaMinhasFinancas.Dtos.Usuarios
{
    public class ReadUsuariosDto
    {
        public int Id { get; set; }        
        public string Nome { get; set; }        
        public string Email { get; set; }
        private string _senha;
        public string Senha
        {
            get { return _senha; }
            set { _senha = Utils.Utils.CalcularHashSHA256(value); }
        }
    }
}

using BibliotecaMinhasFinancas.Data.Dtos.Documentos;
using System.ComponentModel.DataAnnotations;

namespace BibliotecaMinhasFinancas.Dtos.Usuarios
{
    public class ReadUsuariosDto
    {      
        public string NomeCompleto { get; set; }        
        public string UserName { get; set; }      
        public string Email { get; set; }                       
        public DateTime DataNascimento { get; set; }       
        public string PhoneNumber { get; set; }        
        public string FotoBase64 { get; set; } = string.Empty;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMinhasFinancas.Data.Dtos.Usuarios
{
    public class UpdateUsuarioDto
    {
        [Required(ErrorMessage = "Campo Nome Completo é obrigatório!")]
        public string NomeCompleto { get; set; } 

        [Required(ErrorMessage = "Campo E-mail é obrigatório!")]
        public string Email { get; set; }      
        public DateTime DataNascimento { get; set; }
        [Required(ErrorMessage = "Campo Celular")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }   
    }
}

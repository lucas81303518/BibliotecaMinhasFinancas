using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibliotecaMinhasFinancas.Models
{
    public class Usuarios : IdentityUser<int>
    {
        [Required]
        public string NomeCompleto { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime DataNascimento { get; set; }      
        public string FotoBase64 { get; set; } = string.Empty;
        public bool Situacao { get; set; } = false;
        public Usuarios()
               :base()
        {
                          
        }
    }
}

using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibliotecaMinhasFinancas.Models
{
    public class Usuarios : IdentityUser<int>
    {        
        [Required]
        [Column(TypeName = "date")]
        public DateTime DataNascimento { get; set; }       
        public Usuarios()
               :base()
        {
                          
        }
    }
}

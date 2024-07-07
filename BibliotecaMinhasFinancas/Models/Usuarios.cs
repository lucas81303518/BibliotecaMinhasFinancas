using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibliotecaMinhasFinancas.Models
{
    public class Usuarios
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Nome é obrigatório!")]        
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo E-mail é obrigatório!")]        
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo Senha é obrigatório!")]        
        public string Senha { get; set; }  
    }
}

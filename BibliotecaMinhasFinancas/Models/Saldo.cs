using System.ComponentModel.DataAnnotations;


namespace BibliotecaMinhasFinancas.Models
{
    public class Saldo
    {
        [Required]
        public int Id { get; set; }      
        [Required]
        public double ValorTotal { get; set; }  
        [Required]
        public int UsuarioId { get; set; }
        public virtual Usuarios Usuario { get; set; }
    }
}

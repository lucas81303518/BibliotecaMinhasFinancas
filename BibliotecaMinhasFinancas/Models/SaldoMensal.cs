using System.ComponentModel.DataAnnotations;


namespace BibliotecaMinhasFinancas.Models
{
    public class SaldoMensal
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int Mes { get; set; }
        [Required]
        public int Ano { get; set; }
        [Required]
        public double ValorTotal { get; set; }  
        [Required]
        public int UsuarioId { get; set; }
        public virtual Usuarios Usuario { get; set; }
    }
}

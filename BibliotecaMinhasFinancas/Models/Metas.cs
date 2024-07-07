using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibliotecaMinhasFinancas.Models
{
    public class Metas
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Descrição é obrigatório!")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Campo Valor é obrigatório!")]
        public double Valor { get; set; }
        public DateTimeOffset DataInsercao { get; set; }
        public DateTimeOffset DataPrevisao { get; set; }
    }
}

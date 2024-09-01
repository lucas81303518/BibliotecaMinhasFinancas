using System.ComponentModel.DataAnnotations;

namespace BibliotecaMinhasFinancas.Data.Dtos.Metas
{
    public class ReadMetasDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Descrição é obrigatório!")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Campo Valor Objectivo é obrigatório!")]
        public double ValorObjetivo { get; set; }
        [Required(ErrorMessage = "Campo Valor Resultado é obrigatório!")]
        public double ValorResultado { get; set; }
        [Required(ErrorMessage = "Campo Data de Inserção")]
        public DateTime DataInsercao { get; set; }
        [Required]
        public long Cor { get; set; }
        [Required(ErrorMessage = "Campo Data de Previsão")]
        public DateTime DataPrevisao { get; set; }             
    }
}

using System.ComponentModel.DataAnnotations;

namespace BibliotecaMinhasFinancas.Dtos.Metas
{
    public class UpdateMetasDto
    {
        public string Descricao { get; set; }   
        public double Valor { get; set; }
        public DateTime DataInsercao { get; set; }
        public DateTime DataPrevisao { get; set; }
        [Required]
        public int UsuarioId { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace BibliotecaMinhasFinancas.Data.Dtos.Metas
{
    public class ReadMetasDto
    {
        public int Id { get; set; }        
        public string Descricao { get; set; }        
        public double Valor { get; set; }
        public DateTime DataInsercao { get; set; }
        public DateTime DataPrevisao { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace BibliotecaMinhasFinancas.Data.Dtos.Metas
{
    public class ReadMetasDto
    {
        public int Id { get; set; }        
        public string Descricao { get; set; }        
        public double Valor { get; set; }
        public DateTimeOffset DataInsercao { get; set; }
        public DateTimeOffset DataPrevisao { get; set; }
    }
}

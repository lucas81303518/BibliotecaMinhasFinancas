using System.ComponentModel.DataAnnotations;

namespace BibliotecaMinhasFinancas.Data.Dtos.Transferencias
{
    public class ReadTransferenciasDto
    {
        public int Id { get; set; }        
        public string Descricao { get; set; }        
        public int ContaOrigem { get; set; }        
        public int ContaDestino { get; set; }
        public DateTime DataTransferencia { get; set; }        
        public double Valor { get; set; }
    }
}

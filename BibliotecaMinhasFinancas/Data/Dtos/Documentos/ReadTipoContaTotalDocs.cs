using BibliotecaMinhasFinancas.Data.Dtos.TipoContas;

namespace BibliotecaMinhasFinancas.Data.Dtos.Documentos
{
    public class ReadTipoContaTotalDocs : ReadTipoContaDto
    {
        public double ValorTotal { get; set; }
        public DateTime DataDocumento { get; set; }
        public string Descricao { get; set; }
    }
}

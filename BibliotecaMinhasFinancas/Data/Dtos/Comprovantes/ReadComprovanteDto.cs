using BibliotecaMinhasFinancas.Data.Dtos.Documentos;

namespace BibliotecaMinhasFinancas.Data.Dtos.Comprovantes
{
    public class ReadComprovanteDto
    {
        public int Id { get; set; }
        public string TituloArquivo { get; set; }
        public string CaminhoArquivo { get; set; }
        public string TipoComprovante { get; set; }
    }
}

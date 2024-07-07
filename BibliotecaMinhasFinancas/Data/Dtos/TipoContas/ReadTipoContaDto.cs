using BibliotecaMinhasFinancas.Data.Dtos.Documentos;
using System.ComponentModel.DataAnnotations;

namespace BibliotecaMinhasFinancas.Data.Dtos.TipoContas
{
    public class ReadTipoContaDto
    {
        public int Id { get; set; }
        public string NomeConta { get; set; }
        public int Tipo { get; set; }
    }
}

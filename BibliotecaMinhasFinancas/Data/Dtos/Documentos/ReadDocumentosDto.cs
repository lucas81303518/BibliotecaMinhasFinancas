using BibliotecaMinhasFinancas.Dtos.Usuarios;
using BibliotecaMinhasFinancas.Data.Dtos.FormasPagamento;
using BibliotecaMinhasFinancas.Data.Dtos.TipoContas;
using System.ComponentModel.DataAnnotations;

namespace BibliotecaMinhasFinancas.Data.Dtos.Documentos
{
    public class ReadDocumentosDto
    {
        public int Id { get; set; }
        public string NumeroDocumento { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTimeOffset DataDocumento { get; set; }
        public int QtdParcelas { get; set; }
        public string Status { get; set; }
        public int CodigoMeta { get; set; }
        public ReadFormaPagamentoDto FormaPagamento { get; set; }
        public ReadTipoContaDto TipoConta { get; set; }
        public ReadUsuariosDto Usuario { get; set; }
    }
}

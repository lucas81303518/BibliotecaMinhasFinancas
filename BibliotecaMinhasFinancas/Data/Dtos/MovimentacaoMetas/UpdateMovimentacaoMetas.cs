using BibliotecaMinhasFinancas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMinhasFinancas.Data.Dtos.MovimentacaoMetas
{
    public class UpdateMovimentacaoMetas
    {
        [Required]
        public double Valor { get; set; }
        [Required]
        public TipoMovimentacaoMetas TipoOperacao { get; set; }
        [Required]
        public DateTime DataHora { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public int UsuarioId { get; set; }
        [Required]
        public int MetaId { get; set; }
    }
}

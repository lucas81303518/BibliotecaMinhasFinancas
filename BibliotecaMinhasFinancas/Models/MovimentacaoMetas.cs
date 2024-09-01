using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMinhasFinancas.Models
{
    public enum TipoMovimentacaoMetas{
        AlteracaoMeta = 0,
        SomarSaldo = 1,
        SubtrairSaldo = 2
    }
    public class MovimentacaoMetas
    {
        [Key]
        public int Id { get; set; }       
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
        public virtual Usuarios Usuario { get; set; }
        [Required]
        public int MetaId { get; set; }
        public virtual Metas Meta { get; set; }
    }
}

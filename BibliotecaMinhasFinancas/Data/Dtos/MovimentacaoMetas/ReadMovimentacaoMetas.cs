using BibliotecaMinhasFinancas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMinhasFinancas.Data.Dtos.MovimentacaoMetas
{
    public class ReadMovimentacaoMetas
    {    
        public double Valor { get; set; }        
        public TipoMovimentacaoMetas TipoOperacao { get; set; }      
        public DateTime DataHora { get; set; }    
        public string Descricao { get; set; }             
        public int MetaId { get; set; }
    }
}

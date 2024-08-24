using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMinhasFinancas.Models.ModelBase
{
    public class FinanceiroMensal
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int Ano { get; set; }
        [Required]
        public int Mes { get; set; }
        [Required]
        public double ValorTotal { get; set; }
        [Required]
        public int UsuarioId { get; set; }
        public virtual Usuarios Usuario { get; set; }
    }
}

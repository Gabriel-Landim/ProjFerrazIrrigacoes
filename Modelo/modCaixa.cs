using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class modCaixa
    {
        public int Id { get; set; }
        public double TotalFinal { get; set; }
        public double TotalInicial { get; set; }
        public DateTime DataAbertuta { get; set; }
        public DateTime DataFechamento { get; set; }
        public int UsuarioId { get; set; }
        public object Nome { get; set; }
    }
}

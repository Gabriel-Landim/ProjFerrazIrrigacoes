using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class modVenda
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public double ValorVenda { get; set; }
        public int IdCaixa { get; set; }
        public int IdFormaDePagamento { get; set; }
        public int IdCliente { get; set; }
        public double MaodeObra { get; set; }
        public double Desconto { get; set; }
    }
}

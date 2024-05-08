using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class modOrcamentos
    {
        public int Id { get; set; }
        public double Valor { get; set; }
        public DateTime DataOrcamento { get; set; }
        public int IdCliente { get; set; }
        public int IdVenda { get; set; }
    }
}

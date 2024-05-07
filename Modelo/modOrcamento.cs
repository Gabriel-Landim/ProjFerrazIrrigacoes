using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class modOrcamento
    {
        public int Id { get; set; }
        public double Valor { get; set; }
        public DateTime DataOrcamento { get; set; }
        public int IdCliente { get; set; }
        public int IdOrcamento { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class modLancamento
    {
        public int Id { get; set; }
        public string Movimento { get; set; }
        public double Valor { get; set; }
        public string Descricao { get; set; }
        public int IdVenda { get; set; }
        public DateTime Data { get; set; }
    }
}

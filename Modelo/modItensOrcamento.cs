using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class modItensOrcamento
    {
        public int Id { get; set; }
        public double ValorProduto { get; set; }
        public int Quantidade { get; set; }
        public int IdOrcamento { get; set;}
        public int IdProduto { get; set; }
    }
}

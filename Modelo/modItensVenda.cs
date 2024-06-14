using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class modItensVenda
    {
        public int Id {  get; set; }
        public string ProdutoNome { get; set; }
        public double ValorProdutoUnit { get; set; }
        public int Quantidade { get; set; }
        public double ValorTotalProdutos { get; set; }
        public int IdProduto { get; set; }
        public int IdVenda { get; set; }
        
    }
}

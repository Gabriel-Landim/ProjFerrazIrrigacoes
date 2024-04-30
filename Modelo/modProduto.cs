using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class modProduto
    {
        public int Id { get; set; }
        public string NomeProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public int Estoque { get; set; }
        public double ValorProduto { get; set; }
        public int IdMarca { get; set; }
        public int IdCategoriasTipo { get; set; }
        public int IdUnidadeMedidaTipos { get; set; }
    }
}

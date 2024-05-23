using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class bllProduto
    {
        public modProduto BuscaPorCodigo(int id)
        {
            dalProduto objBusca = new dalProduto();
            return objBusca.BuscarPorCodigo(id);
        }
        public List<modProduto> CarregarProduto()
        {
            dalProduto objdados = new dalProduto();
            return objdados.CarregarProduto();
        }
        public List<modProduto> SelecionarPorNome(string nome)
        {
            dalProduto objdados = new dalProduto();
            return objdados.SelecionaPorNome(nome);
        }
    }
}

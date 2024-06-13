using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class bllCaixa
    {
        public void AbrirCaixa(modCaixa objDados)
        {
            if (objDados.DataAbertura.ToString() != "")
            {
                dalCaixa objAbrir = new dalCaixa();
                objAbrir.AbrirCaixa(objDados);
            }
        }

        public void FecharCaixa(string usuario, DateTime dataFechamento, decimal totalFinal)
        {
            modCaixa objDados = new modCaixa();
            if (objDados.DataFechamento.ToString() != "")
            {
                dalCaixa objFechar = new dalCaixa();
                objFechar.FecharCaixa(usuario, dataFechamento, totalFinal);
            }
        }
        public int BuscaPorCodigo()
        {
            dalCaixa objBusca = new dalCaixa();
            return objBusca.BuscarPorCodigo();
        }
    }
}

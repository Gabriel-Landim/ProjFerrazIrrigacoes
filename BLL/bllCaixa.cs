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

        public void FecharCaixa(modCaixa objDados)
        {
            if (objDados.DataFechamento.ToString() != "")
            {
                dalCaixa objFechar = new dalCaixa();
                objFechar.FecharCaixa(objDados);
            }
        }
    }
}

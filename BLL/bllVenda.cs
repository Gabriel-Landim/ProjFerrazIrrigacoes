using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class bllVenda
    {
        public int Insere(modVenda objDados)
        {
            dalVenda objInserir = new dalVenda();
            return objInserir.Insere(objDados);
        }

        public void Alterar(modVenda objDados)
        {
            dalVenda objAlterar = new dalVenda();
            objAlterar.Alterar(objDados);
        }
    }
}

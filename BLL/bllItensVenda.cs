using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class bllItensVenda
    {
        public List<modItensVenda> CarregaItensVenda(int Id)
        {
            dalItensVenda objdados = new dalItensVenda();
            return objdados.CarregaItensVenda(Id);
        }

        public void InsereItem (modItensVenda objDados)
        {
            dalItensVenda objInsere = new dalItensVenda();
            objInsere.Insere(objDados);
        }
    }
}

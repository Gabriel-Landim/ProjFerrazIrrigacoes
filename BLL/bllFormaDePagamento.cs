using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class bllFormaDePagamento
    {
        public List<modFormaDePagamento> CarregaFormaPagamento()
        {
            dalFormaDePagamento objdados = new dalFormaDePagamento();
            return objdados.CarregarFormadePagamento();
        }
    }
}

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

        public void Excluir (int Id)
        {
            dalItensVenda objExcluir = new dalItensVenda();
            objExcluir.Excluir(Id);
        }

        public double Calcula(int objCalculo)
        {
            dalItensVenda objCalcular = new dalItensVenda();
            return objCalcular.Calculo(objCalculo);
        }
    }
}

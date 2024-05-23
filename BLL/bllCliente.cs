using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class bllCliente
    {
        //Gravar
        public void Inserir(modCliente objdados)
        {
            if (objdados.NomeCliente.Trim() != "")
            {
                dalCliente objInserir = new dalCliente();
                objInserir.Insere(objdados);
            }
        }
        public void Alterar(modCliente objdados)
        {
            if ((objdados.NomeCliente.Trim() != "") && (objdados.Id != 0))
            {
                dalCliente objInserir = new dalCliente();
                objInserir.Alterar(objdados);
            }
        }
        public void Excluir(int id)
        {
            if (id != 0)
            {
                dalCliente objExcluir = new dalCliente();
                objExcluir.Excluir(id);
            }
        }
        public modCliente CarregarDadosCliente()
        {
            dalCliente objdados = new dalCliente();
            return objdados.CarregarCliente();
        }

        public List<modCliente> SelecionarPorNome(string nome)
        {
            dalCliente objdados = new dalCliente();
            return objdados.SelecionaPorNome(nome);
        }
    }
}
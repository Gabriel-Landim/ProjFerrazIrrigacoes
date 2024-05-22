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
        public List<modCliente> CarregarCliente(string nome)
        {
            dalCliente objdados = new dalCliente();
            return objdados.CarregarCliente(nome);
        }

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
                dalCliente objAlterar = new dalCliente();
                objAlterar.Alterar(objdados);
            }
        }

        public void Excluir(int Id)
        {
            if (Id != 0)
            {
                dalEmpresa objExcluir = new dalEmpresa();
                objExcluir.Excluir(Id);
            }
        }

        public modEmpresa CarregarDadosEmpresa()
        {
            dalEmpresa objdados = new dalEmpresa();
            return objdados.CarregarDadosEmpresa();
        }
    }
}

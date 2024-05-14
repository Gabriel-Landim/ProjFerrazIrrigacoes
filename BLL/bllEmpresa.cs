using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Modelo;

namespace BLL
{
    public class bllEmpresa
    {
        public List<modEmpresa> CarregarEmpresa(string nome)
        {
            dalEmpresa objdados = new dalEmpresa();
            return objdados.CarregarEmpresa(nome);
        }

        public void Inserir(modEmpresa objdados)
        {
            if ((objdados.NomeFantasia.Trim() != "") && (objdados.Cnpj.Trim() != "")) 
            {
                dalEmpresa objInserir = new dalEmpresa();
                objInserir.Insere(objdados);
            }
        }

        public void Alterar(modEmpresa objdados)
        {
            if ((objdados.NomeFantasia.Trim() != "") && (objdados.Id != 0))
            {
                dalEmpresa objAlterar = new dalEmpresa();
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

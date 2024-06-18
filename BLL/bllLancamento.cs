using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DAL;

namespace BLL
{
    public class bllLancamento
    {
        public void Inserir(modLancamento objdados)
        {
            if (objdados.Movimento.Trim() != "")
            {
                dalLancamento objInserir = new dalLancamento();
                objInserir.Insere(objdados);
            }
        }
        public void InserirLancamento(modLancamento objdados)
        {
            if (objdados.Descricao.Trim() != "")
            {
                dalLancamento objInserir = new dalLancamento();
                objInserir.InsereLancamento(objdados);
            }
        }
        public void Excluir(int id)
        {
            if (id != 0)
            {
                dalLancamento objExcluir = new dalLancamento();
                objExcluir.Excluir(id);
            }
        }
        public List<modLancamento> CarregarLancamento(int caixaId)
        {
            dalLancamento objdados = new dalLancamento();
            return objdados.CarregarLancamento(caixaId);
        }
    }
}

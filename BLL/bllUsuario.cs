using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Modelo;

namespace BLL
{
    public class bllUsuario
    {
        public int Logar(string email, string senha)
        {
            dalUsuario objLogar = new dalUsuario();
            return objLogar.Logar(email, senha);
        }

        public int Cadastrar(string cargo, string id, string nome, string email, string senha)
        {
            dalUsuario objLogar = new dalUsuario();
            return objLogar.Logar(email, senha);
        }

        public void Inserir(modUsuario objdados)
        {
            if (objdados.Nome.Trim() != "")
            {
                dalUsuario objInserir = new dalUsuario();
                objInserir.Insere(objdados);
            }
        }
    }
}

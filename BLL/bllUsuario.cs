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

        public int Cadastrar(string nome, string cargo, string email, string senha)
        {
            dalUsuario objLogar = new dalUsuario();
            modUsuario objModulo = new modUsuario();
            objModulo.Cargo = cargo;
            objModulo.Nome = nome;
            objModulo.Email = email;
            objModulo.Senha = senha;
           return objLogar.Insere(objModulo);
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

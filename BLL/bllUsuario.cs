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
    }
}

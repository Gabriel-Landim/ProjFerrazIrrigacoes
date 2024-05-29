using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class bllCategoriasTipo
    {
        public List<modCategoriasTipos> CarregarCategoria()
        {
            dalCategoriasTipo objdados = new dalCategoriasTipo();
            return objdados.CarregaCategoria();
        }

        public void Inserir(modCategoriasTipos objdados)
        {
            if (objdados.CategoriaNome.Trim() != "")
            {
                dalCategoriasTipo objInserir = new dalCategoriasTipo();
                objInserir.Inserir(objdados);
            }
        }
    }
}

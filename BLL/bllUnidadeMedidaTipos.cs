using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class bllUnidadeMedidaTipos
    {
        public List<modUnidadeMedidaTipos> CarregarUnidadeMedida()
        {
            dalUnidadeMedidaTipos objdados = new dalUnidadeMedidaTipos();
            return objdados.CarregarUnidadeMedida();
        }

        public void Inserir(modUnidadeMedidaTipos objdados)
        {
            if (objdados.NomeMedida.Trim() != "")
            {
                dalUnidadeMedidaTipos objInserir = new dalUnidadeMedidaTipos();
                objInserir.Insere(objdados);
            }
        }
    }
}

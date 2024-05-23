using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class bllMarca
    {
        public List<modMarca> CarregarMarca()
        {
            dalMarca objdados = new dalMarca();
            return objdados.CarregarMarca();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class modEmpresa
    {
        public int Id { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set;}
        public string Cep { get; set;}
        public string NumeroEndereco { get; set;}
        public string Complemento { get; set;}
        public string Cidade { get; set;}
    }
}

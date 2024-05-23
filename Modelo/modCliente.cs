using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class modCliente
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public string Cpf { get; set; }
        public string TelefoneCliente { get; set; }
        public string Email { get; set; }
        public string Rua { get; set; }
        public string NumeroEndereco { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }
        public int IdCidade { get; set; }
        public String CidadeNome { get; set; }
    }
}

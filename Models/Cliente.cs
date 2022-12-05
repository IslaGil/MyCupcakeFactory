using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCupcakeFactory.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public int IdEndereço { get; set; }
        public string CPF { get; set; }

    }
}

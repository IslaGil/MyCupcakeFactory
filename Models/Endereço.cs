using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCupcakeFactory.Models
{
    public class Endereço
    {
        public int Id { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
    }
}

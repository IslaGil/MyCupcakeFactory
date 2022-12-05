using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCupcakeFactory.Models
{
    public class Endereço
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "* Preenchimento obrigatório.")]
        public string CEP { get; set; }
        [Required(ErrorMessage = "* Preenchimento obrigatório.")]
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }

        public virtual List<Pedido> Pedidos { get; set; }
        public virtual List<Cliente> Clientes { get; set; }
    }
}

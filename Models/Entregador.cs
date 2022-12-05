using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCupcakeFactory.Models
{
    public class Entregador
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "* Preenchimento obrigatório.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "* Preenchimento obrigatório.")]
        public virtual List<Pedido> Pedidos { get; set; }
    }
}

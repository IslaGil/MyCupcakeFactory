using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCupcakeFactory.Models
{
    public class Item
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "* Preenchimento obrigatório.")]
        public int IdCategoria { get; set; }
        public virtual Categoria Categoria { get; set; }
        [Required(ErrorMessage = "* Preenchimento obrigatório.")]
        public int IdConfeiteiro { get; set; }
        public virtual Confeiteiro Confeiteiro { get; set; }
        [Required(ErrorMessage = "* Preenchimento obrigatório.")]
        public float Valor { get; set; }

        public virtual List<Pedido> Pedidos { get; set; }
    }
}

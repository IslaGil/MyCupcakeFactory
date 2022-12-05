using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCupcakeFactory.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "* Preenchimento obrigatório.")]
        public int IdCliente { get; set; }
        public virtual Cliente Cliente { get; set; }
        [Required(ErrorMessage = "* Preenchimento obrigatório.")]
        public string Status { get; set; }
        public string FormaDePagamento { get; set; }
        public int IdConfeiteiro { get; set; }
        public virtual Confeiteiro Confeiteiro { get; set; }
        [Required(ErrorMessage = "* Preenchimento obrigatório.")]
        public int IdEntregador { get; set; }
        public virtual Entregador Entregador { get; set; }
        [Required(ErrorMessage = "* Preenchimento obrigatório.")]
        public int IdEndereço { get; set; }
        public virtual Endereço Endereço { get; set; }
        [Required(ErrorMessage = "* Preenchimento obrigatório.")]
        public int IdItem { get; set; }
        public virtual Item Item { get; set; }
        [Required(ErrorMessage = "* Preenchimento obrigatório.")]
        public float Valor { get; set; }
    }
}

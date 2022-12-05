using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCupcakeFactory.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "* Preenchimento obrigatório.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "* Preenchimento obrigatório.")]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "* Preenchimento obrigatório.")]
        public string Email { get; set; }
        public int IdEndereço { get; set; }
        public virtual Endereço Endereço { get; set; }
        [Required(ErrorMessage = "* Preenchimento obrigatório.")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "* Preenchimento obrigatório.")]

        public virtual List<Pedido> Pedidos { get; set; }
    }
}

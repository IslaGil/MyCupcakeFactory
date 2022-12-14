using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCupcakeFactory.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "* Preenchimento obrigatório.")]

        public string Tamanho { get; set; }
        public string Sabor { get; set; }
        public virtual List<Item> Items { get; set; }
    }
}

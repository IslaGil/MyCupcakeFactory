using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyCupcakeFactory.Models;

namespace MyCupcakeFactory.Data
{
    public class MyCupcakeFactoryContext : DbContext
    {
        public MyCupcakeFactoryContext (DbContextOptions<MyCupcakeFactoryContext> options)
            : base(options)
        {
        }

        public DbSet<MyCupcakeFactory.Models.Categoria> Categoria { get; set; }

        public DbSet<MyCupcakeFactory.Models.Cliente> Cliente { get; set; }

        public DbSet<MyCupcakeFactory.Models.Confeiteiro> Confeiteiro { get; set; }

        public DbSet<MyCupcakeFactory.Models.Endereço> Endereço { get; set; }

        public DbSet<MyCupcakeFactory.Models.Entregador> Entregador { get; set; }

        public DbSet<MyCupcakeFactory.Models.Item> Item { get; set; }

        public DbSet<MyCupcakeFactory.Models.Pedido> Pedido { get; set; }
    }
}

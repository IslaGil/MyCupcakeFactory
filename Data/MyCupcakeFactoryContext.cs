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
    }
}

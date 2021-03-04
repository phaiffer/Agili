using Agili.Food.AcessoDados.TypeConfiguration;
using Agili.Food.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agili.Food.AcessoDados.Context
{
    public class AgiliFoodDbContext : DbContext
    {
        public virtual DbSet<Cardapio> Cardapio { get; set; }

        public AgiliFoodDbContext()
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CardapioTypeConfiguration());
        }


    }
}

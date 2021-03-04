using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agili.Food.Comum
{
    public abstract class FoodAbstract<TEntidade> : EntityTypeConfiguration<TEntidade>
        where TEntidade : class
    {
        public FoodAbstract()
        {
            ConfigNameTable();
            ConfigCamposTable();
            ConfigPrimaryKey();
            ConfigForeignKey();
        }

        protected abstract void ConfigForeignKey();

        protected abstract void ConfigPrimaryKey();

        protected abstract void ConfigCamposTable();

        protected abstract void ConfigNameTable();
    }
}

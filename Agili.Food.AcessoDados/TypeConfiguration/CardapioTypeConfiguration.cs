using Agili.Food.Comum;
using Agili.Food.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agili.Food.AcessoDados.TypeConfiguration
{
    class CardapioTypeConfiguration : FoodAbstract<Cardapio>
    {
        protected override void ConfigCamposTable()
        {
            Property(p => p.Id)
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .HasColumnName("IdCardapio");

            Property(p => p.NomeFornecedor)
                .IsRequired()
                .HasColumnName("NomeFornecedor")
                .HasMaxLength(100);

            Property(p => p.Tipo)
                .IsRequired()
                .HasColumnName("Tipo");

            Property(p => p.DataCad)
                .IsRequired()
                .HasColumnName("DataCadastro");

            Property(p => p.NomePedido)
               .IsRequired()
               .HasColumnName("NomePedido")
               .HasMaxLength(50);

            Property(p => p.Valor)
                .IsRequired()
                .HasColumnName("Valor");

        }
        protected override void ConfigPrimaryKey()
        {
            HasKey(pk => pk.Id);
        }
        protected override void ConfigForeignKey()
        {

        }

        protected override void ConfigNameTable()
        {
            ToTable("Cadastro");
        }
    }
}

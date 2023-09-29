using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEstudo.Entidade.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudo.Data.Mapping
{
    public class LojaMap : IEntityTypeConfiguration<Loja>
    {
        public void Configure(EntityTypeBuilder<Loja> builder)
        {
            builder.ToTable("tbLoja");

            builder.HasKey(l => l.IdLoja);

            builder.Property(l => l.IdLoja).IsRequired();

            builder.Property(l => l.Nomeloja).HasColumnName("NomeLoja").IsRequired();

            builder.HasMany(l => l.Produtos)
                  .WithMany(pr => pr.Lojas);
        }
    }
}

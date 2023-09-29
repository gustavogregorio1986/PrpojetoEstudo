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
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("tbProduto");

            builder.HasKey(pr => pr.IdProduto);

            builder.Property(pr => pr.IdProduto).IsRequired();

            builder.Property(pr => pr.NomeProduto).HasColumnName("NomeProduto").IsRequired();

            builder.Property(pr => pr.Descricao).HasColumnName("Descricao").IsRequired();

            builder.HasOne(pr => pr.Pagamento)
                  .WithOne(pa => pa.Produto)
                  .HasForeignKey<Pagamento>(l => l.Id_Produto);
        }
    }
}

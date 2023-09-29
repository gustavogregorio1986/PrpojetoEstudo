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
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("tbEndereco");

            builder.HasKey(e => e.IdEndereco);

            builder.Property(e => e.IdEndereco).IsRequired();

            builder.Property(e => e.Logradouro).HasColumnName("Logradouro").IsRequired();

            builder.Property(e => e.Complemento).HasColumnName("Complemento").IsRequired();

            builder.Property(e => e.Bairro).HasColumnName("Bairro").IsRequired();

            builder.Property(e => e.Complemento).HasColumnName("Complemento").IsRequired();

            builder.Property(e => e.Cidade).HasColumnName("Cidade").IsRequired();

            builder.Property(e => e.Estado).HasColumnName("Estado").IsRequired();

            builder.Property(e => e.Cep).HasColumnName("Cep").IsRequired();
        }
    }
}

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
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("tbPessoa");

            builder.HasKey(p => p.IdPessoa);

            builder.Property(p => p.IdPessoa).IsRequired();

            builder.Property(p => p.NomePessoa).HasColumnName("NomePessoa").IsRequired();

            builder.Property(p => p.EmailPessoa).HasColumnName("EmailPessoa").IsRequired();

            builder.Property(p => p.Sexo).HasColumnName("Sexo").IsRequired();

            builder.Property(p => p.Cpf).HasColumnName("Cpf").IsRequired();

            builder.HasOne(p => p.Endereco)
                  .WithOne(e => e.Pessoa)
                  .HasForeignKey<Endereco>(e => e.Id_Pessoa);

            builder.HasOne(p => p.Loja)
                  .WithOne(l => l.Pessoa)
                  .HasForeignKey<Loja>(l => l.id_Pessoa);
        }
    }
}

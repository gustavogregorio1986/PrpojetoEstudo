﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEstudo.Entidade.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudo.Data.Mapping
{
    public class PagamentoMap : IEntityTypeConfiguration<Pagamento>
    {
        public void Configure(EntityTypeBuilder<Pagamento> builder)
        {
            builder.ToTable("tbPagamento");

            builder.HasKey(pa => pa.IdPagamento);

            builder.Property(pa => pa.IdPagamento).IsRequired();

            builder.Property(pa => pa.Preco).HasColumnName("Preco").IsRequired();

            builder.Property(pa => pa.Quantidade).HasColumnName("Quantidade").IsRequired();
        }
    }
}

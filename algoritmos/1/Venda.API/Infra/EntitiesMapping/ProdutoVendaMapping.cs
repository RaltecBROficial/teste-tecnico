using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaComercial.API.Entities;

namespace SistemaComercial.API.Infra.EntitiesMapping;

public sealed class ProdutoVendaMapping : IEntityTypeConfiguration<ProdutoVenda>
{
    public void Configure(EntityTypeBuilder<ProdutoVenda> builder)
    {
        builder.HasKey(x => x.CodigoProdutoVenda);

        builder.Property(p => p.Nome).HasColumnType("varchar(50)")
            .HasColumnName("nome").IsRequired(true);

        builder.Property(p => p.Desconto).HasColumnType("decimal (5, 2)")
            .HasColumnName("desconto").IsRequired(true);

        builder.Property(p => p.ValorProduto).HasColumnType("decimal (18, 2)")
            .HasColumnName("valor_produto").IsRequired(true);

        builder.Property(p => p.ValorTotal).HasColumnType("decimal (18, 2)")
            .HasColumnName("valor_total").IsRequired(true);

        builder.Property(p => p.Quantidade).HasColumnType("int")
            .HasColumnName("quantidade").IsRequired(true);
    }
}

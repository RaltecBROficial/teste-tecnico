using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaComercial.API.Entities;

namespace SistemaComercial.API.Infra.EntitiesMapping;

public sealed class ProdutoMapping : IEntityTypeConfiguration<Produto>
{
    public void Configure(EntityTypeBuilder<Produto> builder)
    {
        builder.HasKey(x => x.Codigo);

        builder.Property(p => p.Nome).HasColumnType("varchar(50)")
            .HasColumnName("nome").IsRequired(true);

        builder.Property(p => p.ValorUnitario).HasColumnType("decimal(18, 2)")
            .HasColumnName("valor_unitario").IsRequired(true);

        builder.HasMany(p => p.ProdutosVenda)
            .WithOne(p => p.Produto)
            .HasForeignKey(p => p.ProdutoId);

        builder.HasData(
            new Produto()
            {
                Codigo = 1,
                Nome = "produto aleatorio",
                ValorUnitario = 10
            },
            new Produto()
            {
                Codigo = 2,
                Nome = "produto 2",
                ValorUnitario = 30
            },
            new Produto()
            {
                Codigo = 3,
                Nome = "sabonete",
                ValorUnitario = 2
            },
            new Produto()
            {
                Codigo = 4,
                Nome = "ventilador",
                ValorUnitario = 90
            });
    }
}

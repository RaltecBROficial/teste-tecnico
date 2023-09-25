using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaComercial.API.Entities;

namespace SistemaComercial.API.Infra.EntitiesMapping;

public sealed class VendaMapping : IEntityTypeConfiguration<Venda>
{
    public void Configure(EntityTypeBuilder<Venda> builder)
    {
        builder.HasKey(x => x.Numero);

        builder.Property(v => v.Data).HasColumnType("datetime")
            .HasColumnName("data").IsRequired(true);

        builder.Property(v => v.ValorTotal).HasColumnType("decimal(18, 2)")
            .HasColumnName("valor_total").IsRequired(true);

        builder.HasMany(v => v.Produtos)
            .WithOne(p => p.Venda)
            .HasForeignKey(p => p.VendaId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}

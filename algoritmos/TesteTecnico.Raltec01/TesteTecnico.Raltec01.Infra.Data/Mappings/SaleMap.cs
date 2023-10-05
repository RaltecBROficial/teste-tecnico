using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteTecnico.Raltec01.Domain.Entities;

namespace TesteTecnico.Raltec01.Infra.Data.Mappings
{
	public class SaleMap : IEntityTypeConfiguration<Sale>
	{
		public void Configure(EntityTypeBuilder<Sale> builder)
		{
			builder.ToTable("sales");
			builder.HasKey(sale => sale.Id);
			builder.Property(sale => sale.CodeSale).ValueGeneratedOnAdd().IsRequired();
			builder.Property(sale => sale.DateAndHour).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();

			builder.HasMany(sale => sale.Items)
				.WithOne(saleItem => saleItem.Sale)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}

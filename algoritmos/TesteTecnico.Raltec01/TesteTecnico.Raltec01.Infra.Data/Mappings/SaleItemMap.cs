using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteTecnico.Raltec01.Domain.Entities;

namespace TesteTecnico.Raltec01.Infra.Data.Mappings
{
	public class SaleItemMap : IEntityTypeConfiguration<SaleItem>
	{
		public void Configure(EntityTypeBuilder<SaleItem> builder)
		{
			builder.ToTable("sale_items");
			builder.HasKey(saleItem => saleItem.Id);
			builder.Property(saleItem => saleItem.Quantity).HasDefaultValue(1).IsRequired();
			builder.Property(saleItem => saleItem.Value).IsRequired();
			builder.Property(saleItem => saleItem.Discount).IsRequired();
		}
	}
}

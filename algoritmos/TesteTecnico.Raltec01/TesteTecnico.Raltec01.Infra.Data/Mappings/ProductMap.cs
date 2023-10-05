using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteTecnico.Raltec01.Domain.Entities;

namespace TesteTecnico.Raltec01.Infra.Data.Mappings
{
	public class ProductMap : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			builder.ToTable("products");
			builder.HasKey(product => product.Id);
			builder.Property(product => product.Name).HasColumnType("VARCHAR(100)").IsRequired();
			builder.Property(product => product.UnitValue).IsRequired();
		}
	}
}

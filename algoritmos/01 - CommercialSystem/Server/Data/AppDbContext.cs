using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CommercialSystem.Shared.DTOs;
using CommercialSystem.Shared.Entitys;

namespace CommercialSystem.Server.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public DbSet<PRD_PRODUCT> PRD_PRODUCT { get; set; }
        public DbSet<SL_SALE> SL_SALE { get; set; }
        public DbSet<SLI_SALEITEM> SLI_SALEITEM { get; set; }

        public AppDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuração da relação entre Sale e SaleItem
            modelBuilder.Entity<SLI_SALEITEM>()
                .HasOne(si => si.Sale)
                .WithMany(s => s.SaleItems)
                .HasForeignKey(si => si.SaleId);

            // Configuração da relação entre SaleItem e Product
            modelBuilder.Entity<SLI_SALEITEM>()
                .HasOne(si => si.Product)
                .WithMany(p => p.SaleItems)
                .HasForeignKey(si => si.ProductId);
        }
    }
}

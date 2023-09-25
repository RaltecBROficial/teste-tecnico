using Microsoft.EntityFrameworkCore;
using SistemaComercial.API.Entities;

namespace SistemaComercial.API.Infra.Context;

public sealed class SistemaComercialDbContext : DbContext
{
	public SistemaComercialDbContext(DbContextOptions<SistemaComercialDbContext> options) : base(options)
	{

	}

	public DbSet<Produto> Produtos { get; set; }
	public DbSet<ProdutoVenda> ProdutosVenda { get; set; }
	public DbSet<Venda> Vendas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(SistemaComercialDbContext).Assembly);
    }
}

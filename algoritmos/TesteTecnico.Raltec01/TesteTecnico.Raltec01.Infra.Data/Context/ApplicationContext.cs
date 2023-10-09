using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TesteTecnico.Raltec01.Domain.Entities;

namespace TesteTecnico.Raltec01.Infra.Data.Context
{
	public class ApplicationContext : DbContext
	{
		public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}

		DbSet<Product> Products { get; set; }
		DbSet<Sale> Sales { get; set; }
	}
}

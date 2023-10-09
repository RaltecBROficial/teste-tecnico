using TesteTecnico.Raltec01.Domain.Entities;
using TesteTecnico.Raltec01.Domain.Repositories;
using TesteTecnico.Raltec01.Infra.Data.Context;

namespace TesteTecnico.Raltec01.Infra.Data.Repositories
{
	public class ProductRepository : Repository<Product>, IProductRepository
	{
		public ProductRepository(ApplicationContext context) : base(context)
		{
		}
	}
}

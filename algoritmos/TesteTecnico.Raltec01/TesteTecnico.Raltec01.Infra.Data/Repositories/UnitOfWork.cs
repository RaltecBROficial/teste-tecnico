using TesteTecnico.Raltec01.Domain.Repositories;
using TesteTecnico.Raltec01.Infra.Data.Context;

namespace TesteTecnico.Raltec01.Infra.Data.Repositories
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly ApplicationContext _context;
		private readonly IProductRepository _productRepository;
		private readonly ISaleRepository _saleRepository;

		public UnitOfWork(ApplicationContext context)
		{
			_context = context;
			_productRepository = new ProductRepository(_context);
			_saleRepository = new SaleRepository(_context);
		}

		public async Task SaveAsync()
		{
			await _context.SaveChangesAsync();
		}

		public async ValueTask DisposeAsync()
		{
			await _context.DisposeAsync();
			GC.SuppressFinalize(this);
		}

		public IProductRepository ProductRepository => _productRepository;

		public ISaleRepository SaleRepository => _saleRepository;
	}
}

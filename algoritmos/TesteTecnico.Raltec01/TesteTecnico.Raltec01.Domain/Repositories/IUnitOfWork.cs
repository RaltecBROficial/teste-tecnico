namespace TesteTecnico.Raltec01.Domain.Repositories
{
	public interface IUnitOfWork : IAsyncDisposable
	{
		IProductRepository ProductRepository { get; }
		ISaleRepository SaleRepository { get; }

		Task SaveAsync();
	}
}

namespace TesteTecnico.Raltec01.Application.Interfaces
{
	public interface IAppService<T> : IDisposable where T : class
	{
		Task<T> GetByIdAsync(Guid id);
		Task<IEnumerable<T>> GetAllAsync();
		Task AddAsync(T entity);
		Task UpdateAsync(T entity);
		Task RemoveAsync(T entity);
	}
}

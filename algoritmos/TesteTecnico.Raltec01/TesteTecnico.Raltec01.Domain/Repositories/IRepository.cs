namespace TesteTecnico.Raltec01.Domain.Repositories
{
	public interface IRepository<T> where T : class
	{
		Task<T> GetByIdAsync(Guid id);
		Task<IEnumerable<T>> GetAllAsync();
		Task<T> AddAsync(T entity);
		Task UpdateAsync(T entity);
		Task RemoveAsync(T entity);
	}
}

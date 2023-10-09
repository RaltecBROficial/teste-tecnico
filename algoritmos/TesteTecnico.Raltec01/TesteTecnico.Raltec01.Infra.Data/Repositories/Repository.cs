using Microsoft.EntityFrameworkCore;
using TesteTecnico.Raltec01.Domain.Repositories;
using TesteTecnico.Raltec01.Infra.Data.Context;

namespace TesteTecnico.Raltec01.Infra.Data.Repositories
{
	public class Repository<T> : IRepository<T> where T : class
	{
		private readonly ApplicationContext _context;
		private readonly DbSet<T> _dbSet;

		public Repository(ApplicationContext context)
		{
			_context = context;
			_dbSet = _context.Set<T>();
		}

		public async Task<T> GetByIdAsync(Guid id)
		{
			return await _dbSet.FindAsync(id);
		}

		public async Task<IEnumerable<T>> GetAllAsync()
		{
			return await _dbSet.AsNoTracking().ToListAsync();
		}

		public async Task<T> AddAsync(T entity)
		{
			await _dbSet.AddAsync(entity);
			return entity;
		}

		public Task UpdateAsync(T entity)
		{
			_dbSet.Attach(entity);
			_dbSet.Entry(entity).State = EntityState.Modified;
			return Task.CompletedTask;
		}

		public Task RemoveAsync(T entity)
		{
			_dbSet.Remove(entity);
			return Task.CompletedTask;
		}
	}
}

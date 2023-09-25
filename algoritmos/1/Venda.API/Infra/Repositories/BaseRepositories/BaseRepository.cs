using Microsoft.EntityFrameworkCore;
using SistemaComercial.API.Infra.Context;

namespace SistemaComercial.API.Infra.Repositories.BaseRepositories;

public abstract class BaseRepository<TEntity> : IDisposable
    where TEntity : class
{
    protected readonly SistemaComercialDbContext _dbContext;
    protected DbSet<TEntity> _dbContextSet => _dbContext.Set<TEntity>();

    public BaseRepository(SistemaComercialDbContext dbContext)
	{
		_dbContext = dbContext;
	}

    public void Dispose() => 
		_dbContext.Dispose();
}

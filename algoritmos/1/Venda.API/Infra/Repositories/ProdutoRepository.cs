using Microsoft.EntityFrameworkCore;
using SistemaComercial.API.Entities;
using SistemaComercial.API.Infra.Context;
using SistemaComercial.API.Infra.Repositories.BaseRepositories;
using SistemaComercial.API.Interfaces.Repositories;

namespace SistemaComercial.API.Infra.Repositories;

public sealed class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
{
    public ProdutoRepository(SistemaComercialDbContext dbContext) : base(dbContext)
    {
    }

    public async Task AddAsync(Produto produto)
    {
        await _dbContextSet.AddAsync(produto);

        await _dbContext.SaveChangesAsync();
    }

    public async Task<List<Produto>> GetAllAsync() =>
        await _dbContextSet.AsNoTracking().ToListAsync();

    public async Task<bool> ExistsAsync(int codigo) =>
        await _dbContextSet.AnyAsync(p => p.Codigo == codigo);

    public async Task<Produto> GetProdutoByCodigoAsync(int codigo) =>
        await _dbContextSet.FirstOrDefaultAsync(p => p.Codigo == codigo);
}

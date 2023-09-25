using Microsoft.EntityFrameworkCore;
using SistemaComercial.API.Entities;
using SistemaComercial.API.Infra.Context;
using SistemaComercial.API.Infra.Repositories.BaseRepositories;
using SistemaComercial.API.Interfaces.Repositories;

namespace SistemaComercial.API.Infra.Repositories;

public sealed class VendaRepository : BaseRepository<Venda>, IVendaRepository
{
    public VendaRepository(SistemaComercialDbContext dbContext) : base(dbContext)
    {
    }

    public async Task AddAsync(Venda venda)
    {
        await _dbContextSet.AddAsync(venda);

        await _dbContext.SaveChangesAsync();
    }

    public async Task<List<Venda>> GetAllAsync() =>
        await _dbContextSet
            .AsNoTracking()
            .Include(v => v.Produtos)
            .ToListAsync();
}

using SistemaComercial.API.Entities;

namespace SistemaComercial.API.Interfaces.Repositories;

public interface IVendaRepository
{
    Task AddAsync(Venda venda);
    Task<List<Venda>> GetAllAsync();
}

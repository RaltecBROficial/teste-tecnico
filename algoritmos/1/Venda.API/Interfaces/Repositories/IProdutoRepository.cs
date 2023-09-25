using SistemaComercial.API.Entities;

namespace SistemaComercial.API.Interfaces.Repositories;

public interface IProdutoRepository
{
    Task AddAsync(Produto produto);
    Task<List<Produto>> GetAllAsync();
    Task<bool> ExistsAsync(int codigo);
    Task<Produto> GetProdutoByCodigoAsync(int codigo);
}

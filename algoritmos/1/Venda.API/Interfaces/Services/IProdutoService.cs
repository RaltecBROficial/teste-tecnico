using SistemaComercial.API.DataTransferObjects.Requests.Produto;
using SistemaComercial.API.DataTransferObjects.Responses.Produto;

namespace SistemaComercial.API.Interfaces.Services;

public interface IProdutoService
{
    Task AddAsync(ProdutoRequest produtoRequest);
    Task<List<ProdutoResponse>> GetAllAsync();
}

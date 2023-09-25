using SistemaComercial.API.DataTransferObjects.Requests.Produto;
using SistemaComercial.API.DataTransferObjects.Responses.Produto;
using SistemaComercial.API.Entities;

namespace SistemaComercial.API.Interfaces.Mappers;

public interface IProdutoMapper
{
    Produto RequestToDomain(ProdutoRequest produtoRequest);
    ProdutoResponse DomainToResponse(Produto produto);
}

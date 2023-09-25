using SistemaComercial.API.DataTransferObjects.Requests.Produto;
using SistemaComercial.API.DataTransferObjects.Responses.Produto;
using SistemaComercial.API.Entities;
using SistemaComercial.API.Interfaces.Mappers;

namespace SistemaComercial.API.Mappers;

public sealed class ProdutoMapper : IProdutoMapper
{
    public Produto RequestToDomain(ProdutoRequest produtoRequest) =>
        new Produto()
        {
            Nome = produtoRequest.Nome,
            ValorUnitario = produtoRequest.ValorUnitario
        };

    public ProdutoResponse DomainToResponse(Produto produto) =>
        new ProdutoResponse()
        {
            Nome = produto.Nome,
            ValorUnitario = produto.ValorUnitario,
            Codigo = produto.Codigo
        };
}

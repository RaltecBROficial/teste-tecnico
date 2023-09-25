using SistemaComercial.API.DataTransferObjects.Responses.ProdutoVenda;
using SistemaComercial.API.Entities;
using SistemaComercial.API.Interfaces.Mappers;

namespace SistemaComercial.API.Mappers;

public sealed class ProdutoVendaMapper : IProdutoVendaMapper
{
    public ProdutoVendaResponse DomainToResponse(ProdutoVenda produtoVenda) =>
        new ProdutoVendaResponse()
        {
            CodigoProdutoVenda = produtoVenda.CodigoProdutoVenda,
            Desconto = produtoVenda.Desconto,
            Nome = produtoVenda.Nome,
            ProdutoId = produtoVenda.ProdutoId,
            Quantidade = produtoVenda.Quantidade,
            ValorProduto = produtoVenda.ValorProduto,
            ValorTotal = produtoVenda.ValorTotal
        };
}

using SistemaComercial.API.DataTransferObjects.Responses.ProdutoVenda;
using SistemaComercial.API.Entities;

namespace SistemaComercial.API.Interfaces.Mappers;

public interface IProdutoVendaMapper
{
    ProdutoVendaResponse DomainToResponse(ProdutoVenda produtoVenda);
}

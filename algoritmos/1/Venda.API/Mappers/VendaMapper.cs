using SistemaComercial.API.DataTransferObjects.Responses.ProdutoVenda;
using SistemaComercial.API.DataTransferObjects.Responses.Venda;
using SistemaComercial.API.Entities;
using SistemaComercial.API.Interfaces.Mappers;

namespace SistemaComercial.API.Mappers;

public sealed class VendaMapper : IVendaMapper
{
    private readonly IProdutoVendaMapper _produtoVendaMapper;

	public VendaMapper(IProdutoVendaMapper produtoVendaMapper)
	{
		_produtoVendaMapper = produtoVendaMapper;
	}

    public VendaResponse DomainToResponse(Venda venda)
    {
        var produtoVendaResponseList = new List<ProdutoVendaResponse>();

        foreach(var produtoVenda in venda.Produtos)
        {
            produtoVendaResponseList.Add(_produtoVendaMapper.DomainToResponse(produtoVenda));
        }

        return new VendaResponse()
        {
            Data = venda.Data,
            Numero = venda.Numero,
            Produtos = produtoVendaResponseList,
            ValorTotal = venda.ValorTotal
        };
    }
}

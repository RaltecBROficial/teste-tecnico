using SistemaComercial.API.DataTransferObjects.Requests.ProdutoVenda;

namespace SistemaComercial.API.DataTransferObjects.Requests.Venda;

public sealed class VendaRequest
{
    public List<ProdutoVendaRequest> Produtos { get; set; }
}

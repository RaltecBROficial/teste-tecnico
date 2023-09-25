using SistemaComercial.API.DataTransferObjects.Responses.ProdutoVenda;

namespace SistemaComercial.API.DataTransferObjects.Responses.Venda;

public sealed class VendaResponse
{
    public required int Numero { get; set; }
    public required DateTime Data { get; set; }
    public required decimal ValorTotal { get; set; }

    public List<ProdutoVendaResponse> Produtos { get; set; }
}

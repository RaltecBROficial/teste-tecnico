namespace SistemaComercial.API.DataTransferObjects.Responses.ProdutoVenda;

public sealed class ProdutoVendaResponse
{
    public required int CodigoProdutoVenda { get; set; }
    public required string Nome { get; set; }
    public required decimal Desconto { get; set; }
    public required decimal ValorProduto { get; set; }
    public required decimal ValorTotal { get; set; }
    public required int Quantidade { get; set; }
    public required int ProdutoId { get; set; }
}

namespace SistemaComercial.API.DataTransferObjects.Requests.Produto;

public sealed class ProdutoRequest
{
    public required string Nome { get; set; }
    public required decimal ValorUnitario { get; set; }
}

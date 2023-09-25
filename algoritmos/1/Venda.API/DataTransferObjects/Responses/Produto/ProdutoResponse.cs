namespace SistemaComercial.API.DataTransferObjects.Responses.Produto;

public sealed class ProdutoResponse
{
    public required int Codigo { get; set; }
    public required string Nome { get; set; }
    public required decimal ValorUnitario { get; set; }
}

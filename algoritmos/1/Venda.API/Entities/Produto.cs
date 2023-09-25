namespace SistemaComercial.API.Entities;

public sealed class Produto
{
    public int Codigo { get; set; }
    public required string Nome { get; set; }
    public required decimal ValorUnitario { get; set; }

    public List<ProdutoVenda> ProdutosVenda { get; set; }
}

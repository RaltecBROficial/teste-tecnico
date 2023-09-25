namespace SistemaComercial.API.Entities;

public sealed class ProdutoVenda
{
    public int CodigoProdutoVenda { get; set; }
    public required string Nome { get; set; }
    public required decimal Desconto { get; set; }
    public required decimal ValorProduto { get; set; }
    public required decimal ValorTotal { get; set; }
    public required int Quantidade { get; set; }

    public int ProdutoId { get; set; }
    public Produto Produto { get; set; }
    public int VendaId { get; set; }
    public Venda Venda { get; set; }
}

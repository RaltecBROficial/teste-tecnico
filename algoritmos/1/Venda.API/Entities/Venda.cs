namespace SistemaComercial.API.Entities;

public sealed class Venda
{
    public int Numero { get; set; }
    public DateTime Data { get; set; }
    public decimal ValorTotal { get; set; }
    public List<ProdutoVenda> Produtos { get; set; }
}

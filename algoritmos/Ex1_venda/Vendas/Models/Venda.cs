namespace Vendas.Models;

public class Venda
{
    public Guid NumeroVenda { get; } = new();
    public DateTime DataHora { get; } = DateTime.Now;
    public List<ItemVenda> ItensVendidos { get; } = new();

    public void AddItem(Produto produto, int quantidade)
    {
        ItensVendidos.Add(new ItemVenda(produto, quantidade));
    }
    
    public decimal CalcularTotalVenda()
    {
        decimal total = 0;
        foreach (var item in ItensVendidos)
        {
            var desconto = item.CalcularDesconto();
            total += item.Produto.ValorUnitario  * item.Quantidade - desconto;
        }
        return total;
    }
}
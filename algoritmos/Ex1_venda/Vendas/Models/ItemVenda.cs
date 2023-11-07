namespace Vendas.Models;

public class ItemVenda
{
    public Produto Produto { get; set; }
    public int Quantidade { get; set; }

    public ItemVenda(Produto produto, int quantidade)
    {
        Produto = produto;
        Quantidade = quantidade;
    }

    public decimal CalcularDesconto()
    {
        decimal desconto = 0;

        if (Quantidade > 30)
        {
            desconto = (decimal)0.20;
        }else if (Quantidade > 20)
        {
            desconto = (decimal)0.10;
        }else if (Quantidade > 10)
        {
            desconto = (decimal)0.05;
        }

        return Produto.ValorUnitario * Quantidade * desconto ;
    }
}
// See https://aka.ms/new-console-template for more information

using Vendas.Models;

var produto1 = new Produto(1, "Produto 1", 10);
var produto2 = new Produto(2, "Produto 2", 15);
 
Venda venda1 = new Venda();
venda1.AddItem(produto1, 12);
venda1.AddItem(produto2, 25);

Console.WriteLine("Número da Venda (GUID): " + venda1.NumeroVenda);
Console.WriteLine("Data e Hora: " + venda1.DataHora);
Console.WriteLine("Itens Vendidos:");

foreach (var item in venda1.ItensVendidos)
{
    Console.WriteLine("Produto: " + item.Produto.Nome);
    Console.WriteLine("Quantidade: " + item.Quantidade);
    Console.WriteLine("Desconto: " + item.CalcularDesconto());
}

Console.WriteLine("Total da Venda: " + venda1.CalcularTotalVenda().ToString("C"));
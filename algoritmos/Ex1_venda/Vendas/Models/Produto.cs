namespace Vendas.Models;

public class Produto
{
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public decimal ValorUnitario { get; set; }
    
    public Produto(int codigo, string nome, decimal valorUnitario)
    {
        Codigo = codigo;
        Nome = nome;
        ValorUnitario = valorUnitario;
    }
}
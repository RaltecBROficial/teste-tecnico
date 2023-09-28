// Classe base Animal
public class Animal
{
    public double Peso { get; set; }
    public int QuantidadePatas { get; set; }

    public Animal(double peso, int patas)
    {
        Peso = peso;
        QuantidadePatas = patas;
    }

    public void Andar()
    {
        Console.WriteLine("O animal está andando.");
    }

    public virtual void Comer()
    {
        Console.WriteLine("O animal está comendo.");
    }
}
public class Cao : Mamifero
{
    public Cao(double peso, int patas) : base(peso, patas)
    {
    }

    public void Atacar()
    {
        Console.WriteLine("O cão está atacando.");
    }

    public override void Comer()
    {
        Console.WriteLine("O cão está comendo sua ração.");
    }
}
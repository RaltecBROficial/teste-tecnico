namespace challenge_opp.Entities;
public sealed class Cao : Mamifero
{
    public Cao(double peso, int quantidadeDePatas) : base(peso, quantidadeDePatas)
    {
    }

    public void Atacar() =>
        Console.WriteLine("Este cão está atacando");
}

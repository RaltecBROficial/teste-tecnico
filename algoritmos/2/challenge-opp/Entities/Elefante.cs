namespace challenge_opp.Entities;
public sealed class Elefante : Mamifero
{
    public Elefante(double peso, int quantidadeDePatas) : base(peso, quantidadeDePatas)
    {
    }

    public override void Comer()
    {
        Console.WriteLine("Elefante come de uma forma diferente");
    }
}

using challenge_opp.Interfaces;

namespace challenge_opp.Entities;
public sealed class Pato : Ave, IVoo
{
    public Pato(double peso, int quantidadeDePatas) : base(peso, quantidadeDePatas)
    {
    }

    public void Voar() =>
        Console.WriteLine("Pato voa");
}

using challenge_opp.Interfaces;

namespace challenge_opp.Entities;
public sealed class Andorinha : Ave, IVoo
{
    public Andorinha(double peso, int quantidadeDePatas) : base(peso, quantidadeDePatas)
    {
    }

    public void Voar() =>
        Console.WriteLine("Andorinha voa");
}

public class Pato : Ave, IVoavel
{
    public Pato(double peso, int patas) : base(peso, patas)
    {
    }

    public override void Comer()
    {
        Console.WriteLine("O pato está comendo migalhas de pão.");
    }

    public void Voar()
    {
        Console.WriteLine("O pato está voando.");
    }
}
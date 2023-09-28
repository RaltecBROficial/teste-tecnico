public class Andorinha : Ave, IVoavel
{
    public Andorinha(double peso, int patas) : base(peso, patas)
    {
    }

    public override void Comer()
    {
        Console.WriteLine("A andorinha está comendo insetos.");
    }

    public void Voar()
    {
        Console.WriteLine("A andorinha está voando.");
    }
}
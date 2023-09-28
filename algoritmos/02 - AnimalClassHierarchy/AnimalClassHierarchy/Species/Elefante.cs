public class Elefante : Mamifero
{
    public Elefante(double peso, int patas) : base(peso, patas)
    {
    }

    public override void Comer()
    {
        Console.WriteLine("O elefante está usando sua tromba para comer.");
    }
}
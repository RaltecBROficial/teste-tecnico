// Classe Mamifero, subclasse de Animal
public class Mamifero : Animal
{
    public Mamifero(double peso, int patas) : base(peso, patas)
    {
    }

    public void Amamentar()
    {
        Console.WriteLine("O mamífero está amamentando.");
    }
}
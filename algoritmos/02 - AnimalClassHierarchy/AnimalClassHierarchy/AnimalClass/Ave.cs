// Classe Ave, subclasse de Animal
public class Ave : Animal
{
    public Ave(double peso, int patas) : base(peso, patas)
    {
    }

    public void Voar()
    {
        Console.WriteLine("A ave está voando.");
    }
}
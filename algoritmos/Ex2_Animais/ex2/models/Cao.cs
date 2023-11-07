namespace Animal;

public class Cao : Mamifero
{
    public Cao(double peso) : base(peso, 4)
    {
    }

    public string Atacar()
    {
        return "Atacar";
    }
}
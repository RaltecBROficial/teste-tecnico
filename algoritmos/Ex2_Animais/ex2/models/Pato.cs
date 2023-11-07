namespace Animal;

public class Pato:Ave
{
    public Pato(double peso, int patas) : base(peso, patas)
    {
    }
    public string Voar()
    {
        return "Voando";
    }
}
namespace Animal;

public class Andorinha:Ave
{
    public Andorinha(double peso, int patas) : base(peso, patas)
    {
    }

    public string Voar()
    {
        return "Voando";
    }
}
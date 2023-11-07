namespace Animal;

public abstract class Animal
{
    public double Peso  { get; set; }
    public int Patas { get; set; }

    protected Animal(double peso, int patas)
    {
        Peso = peso;
        Patas = patas;
    }

    public string Andar()
    {
        return "Andou";
    }

    public string Comer()
    {
        return "Comeu";
    }
}
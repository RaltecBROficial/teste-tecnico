namespace Animal;

public class Elefante : Mamifero
{
    public Elefante(double peso) : base(peso, 4)
    {
    }

    public string Comer()
    {
        return "Comendo diferente";
    }
}
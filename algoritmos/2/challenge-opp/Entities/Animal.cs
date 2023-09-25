namespace challenge_opp.Entities;
public abstract class Animal
{
    public double Peso { get; private set; }
    public int QuantidadeDePatas { get; private set; }

    public Animal(double peso, int quantidadeDePatas)
    {
        Peso = peso;
        QuantidadeDePatas = quantidadeDePatas;
    }

    public void Andar() =>
        Console.WriteLine($"{GetType().Name} andou.");

    public virtual void Comer() =>
        Console.WriteLine($"{GetType().Name} comeu.");


}

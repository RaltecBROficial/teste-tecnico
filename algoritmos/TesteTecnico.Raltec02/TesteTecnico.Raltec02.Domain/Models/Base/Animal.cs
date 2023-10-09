namespace TesteTecnico.Raltec02.Domain.Models.Base
{
	public abstract class Animal
	{
		public double Peso { get; set; }
		public int QuantidadePatas { get; set; }

		public virtual void Andar()
		{
			Console.WriteLine("estou andando.");
		}

		public virtual void Comer()
		{
			Console.WriteLine("estou comendo.");
		}
	}
}

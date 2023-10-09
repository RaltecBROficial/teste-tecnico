using TesteTecnico.Raltec02.Domain.Models.Super;

namespace TesteTecnico.Raltec02.Domain.Models.Concretas.Mamimeferos
{
	public class Elefante : Mamifero
	{
		public override void Comer()
		{
			Console.WriteLine("estou comendo pegando a comida com a minha tromba.");
		}
	}
}

using TesteTecnico.Raltec02.Domain.Models.Super;

namespace TesteTecnico.Raltec02.Domain.Models.Concretas.Mamimeferos
{
	public class Cao : Mamifero
	{
		public override void Comer()
		{
			Console.WriteLine("Sou cão e... ");
			base.Comer();
		}
	}
}

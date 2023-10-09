using TesteTecnico.Raltec02.Domain.Interfaces;
using TesteTecnico.Raltec02.Domain.Models.Super;

namespace TesteTecnico.Raltec02.Domain.Models.Concretas.Aves
{
	public class Pato : Ave, IVoar
	{
		public void Voe()
		{
			Console.WriteLine("estou voando.");
		}
	}
}

using System.ComponentModel.DataAnnotations;

namespace TesteTecnico.Raltec01.Application.ViewModels
{
	public class ProductViewModel
	{
		public Guid Id { get; set; }

		[Required(ErrorMessage = "The Name is Required")]
		[MinLength(2)]
		[MaxLength(100)]
		public string Name { get; set; }

		[Required(ErrorMessage = "The unit value is Required")]
		public decimal UnitValue { get; set; }
	}
}

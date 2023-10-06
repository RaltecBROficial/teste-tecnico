namespace TesteTecnico.Raltec01.Application.ViewModels
{
	public class SaleViewModel
	{
		public Guid Id { get; set; }
		public int CodeSale { get; set; }
		public DateTime DateAndHour { get; set; }
		public ICollection<SaleItemViewModel> Items { get; set; }
	}
}

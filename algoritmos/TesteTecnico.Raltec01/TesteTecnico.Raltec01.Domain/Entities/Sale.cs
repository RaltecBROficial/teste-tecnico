namespace TesteTecnico.Raltec01.Domain.Entities
{
	public class Sale : BaseEntity
	{
		public int CodeSale { get; set; }
		public DateTime DateAndHour { get; set; }
		public ICollection<SaleItem> Items { get; set; }
	}
}

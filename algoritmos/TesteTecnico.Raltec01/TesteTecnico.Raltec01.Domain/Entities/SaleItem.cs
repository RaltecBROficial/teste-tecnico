namespace TesteTecnico.Raltec01.Domain.Entities
{
	public class SaleItem : BaseEntity
	{
		public Product Product { get; set; }
		public Sale Sale { get; set; }
		public int Quantity { get; set; }
		public decimal Value { get; set; }
		public decimal Discount { get; set; }
	}
}

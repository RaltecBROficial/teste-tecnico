namespace TesteTecnico.Raltec01.Domain.Entities
{
	public abstract class BaseEntity
	{
		public Guid Id { get; } = Guid.NewGuid();
	}
}

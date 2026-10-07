namespace LostAndFound.Domain.Entities;

public abstract class AuditableEntity : Entity
{
	public DateTimeOffset CreatedAt { get; set; }

	public Guid CreatedBy { get; set; }

	public DateTimeOffset? UpdatedAt { get; set; }

	public Guid? UpdatedBy { get; set; }
}

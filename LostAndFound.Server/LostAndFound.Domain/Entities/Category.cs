namespace LostAndFound.Domain.Entities;

public class Category : AuditableEntity
{
	public required string Name { get; set; }

	public ICollection<Post>? Posts { get; set; } = [];
}

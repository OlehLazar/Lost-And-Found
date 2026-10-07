namespace LostAndFound.Domain.Entities;

public class User : AuditableEntity
{
	public required string UserName { get; set; }

	public required string FirstName { get; set; }

	public required string LastName { get; set; }

	public ICollection<Post>? Posts { get; set; } = [];
}

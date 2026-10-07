using LostAndFound.Domain.Enums;

namespace LostAndFound.Domain.Entities;

public class Post : AuditableEntity
{
	public Guid CreatorId { get; set; }

	public User? Creator { get; set; }

	public Guid CategoryId { get; set; }

	public Category? Category { get; set; }

	public PostType Type { get; set; }

	public PostStatus Status { get; set; }

	public required string Title { get; set; }

	public required string Description { get; set; }

	public required string Location { get; set; }

	public DateTimeOffset Date { get; set; }
}

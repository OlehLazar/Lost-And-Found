namespace LostAndFound.Domain.Interfaces;

public interface ICurrentUser
{
	public Guid Id { get; }

	public bool IsAuthenticated { get; }
}

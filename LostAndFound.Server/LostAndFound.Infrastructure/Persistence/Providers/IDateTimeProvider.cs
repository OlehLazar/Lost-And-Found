namespace LostAndFound.Infrastructure.Persistence.Providers;

internal interface IDateTimeProvider
{
	DateTimeOffset UtcNow { get; }
}

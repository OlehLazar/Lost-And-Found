namespace LostAndFound.Infrastructure.Persistence.Providers;

internal class DateTimeProvider : IDateTimeProvider
{
	public DateTimeOffset UtcNow => DateTimeOffset.UtcNow;
}

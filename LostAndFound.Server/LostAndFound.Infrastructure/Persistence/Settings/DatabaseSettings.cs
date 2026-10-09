namespace LostAndFound.Infrastructure.Persistence.Settings;

internal class DatabaseSettings
{
	public const string SectionName = "DatabaseSettings";

	public string ConnectionString { get; set; } = string.Empty;
}

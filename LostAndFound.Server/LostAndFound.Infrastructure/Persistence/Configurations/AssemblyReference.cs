using System.Reflection;

namespace LostAndFound.Infrastructure.Persistence.Configurations;

internal static class AssemblyReference
{
	public static readonly Assembly Assembly = typeof(AssemblyReference).Assembly;
}

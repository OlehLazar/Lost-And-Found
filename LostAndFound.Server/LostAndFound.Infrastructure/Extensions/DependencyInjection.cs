using LostAndFound.Application.Interfaces.Repositories;
using LostAndFound.Domain.Interfaces;
using LostAndFound.Infrastructure.Persistence;
using LostAndFound.Infrastructure.Persistence.Interceptors;
using LostAndFound.Infrastructure.Persistence.Providers;
using LostAndFound.Infrastructure.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace LostAndFound.Infrastructure.Extensions;

public static class DependencyInjection
{
	private static IServiceCollection AddInfrastructure(this IServiceCollection services)
	{
		return services
			.AddDateTimeProvider()
			.AddCustomInterceptors()
			.AddUnitOfWork()
			.AddRepositories();
	}

	private static IServiceCollection AddDateTimeProvider(this IServiceCollection services)
	{
		return services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
	}

	private static IServiceCollection AddCustomInterceptors(this IServiceCollection services)
	{
		return services.AddSingleton<UpdateAuditableEntitiesInterceptor>();
	}

	private static IServiceCollection AddRepositories(this IServiceCollection services)
	{
		return services
			.AddScoped<IUserRepository, UserRepository>()
			.AddScoped<IPostRepository, PostRepository>()
			.AddScoped<ICategoryRepository, CategoryRepository>();
	}

	private static IServiceCollection AddUnitOfWork(this IServiceCollection services)
	{
		return services.AddScoped<IUnitOfWork, UnitOfWork>();
	}
}

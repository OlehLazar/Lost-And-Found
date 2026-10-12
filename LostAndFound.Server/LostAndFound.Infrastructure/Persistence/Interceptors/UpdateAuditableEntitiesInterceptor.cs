using LostAndFound.Domain.Entities;
using LostAndFound.Domain.Interfaces;
using LostAndFound.Infrastructure.Persistence.Providers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace LostAndFound.Infrastructure.Persistence.Interceptors;

internal class UpdateAuditableEntitiesInterceptor(
	IDateTimeProvider provider,
	ICurrentUser currentUser)
	: SaveChangesInterceptor
{
	public override ValueTask<InterceptionResult<int>> SavingChangesAsync(
		DbContextEventData eventData,
		InterceptionResult<int> result,
		CancellationToken cancellationToken = default)
	{
		var context = eventData.Context;

		if (context is null)
		{
			return base.SavingChangesAsync(eventData, result, cancellationToken);
		}

		var entries = context.ChangeTracker.Entries<AuditableEntity>();

		foreach (var entry in entries)
		{
			if (entry.State == EntityState.Added)
			{
				var createdBy = currentUser.IsAuthenticated ? currentUser.Id : entry.Entity.Id;

				entry.Entity.CreatedAt = provider.UtcNow;
				entry.Entity.CreatedBy = createdBy;
			}
			else if (entry.State == EntityState.Modified)
			{
				entry.Entity.UpdatedAt = provider.UtcNow;
				entry.Entity.UpdatedBy = currentUser.Id;
			}
		}

		return base.SavingChangesAsync(eventData, result, cancellationToken);
	}
}

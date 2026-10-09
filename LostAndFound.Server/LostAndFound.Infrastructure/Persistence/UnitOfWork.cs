using LostAndFound.Domain.Interfaces;

namespace LostAndFound.Infrastructure.Persistence;

internal sealed class UnitOfWork(
	LostAndFoundDbContext dbContext)
	: IUnitOfWork
{
	public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
	{
		return await dbContext.SaveChangesAsync(cancellationToken);
	}
}

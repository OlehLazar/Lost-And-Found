using LostAndFound.Application.Interfaces.Repositories;
using LostAndFound.Domain.Entities;

namespace LostAndFound.Infrastructure.Persistence.Repositories;

internal class BaseRepository<TEntity>(LostAndFoundDbContext context)
	: IRepository<TEntity>
	where TEntity : Entity
{
	protected readonly LostAndFoundDbContext _context = context;

	public Task AddAsync(TEntity entity, CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public void Delete(TEntity entity)
	{
		throw new NotImplementedException();
	}

	public Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public Task<TEntity?> GetAsync(Guid id, CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public void Update(TEntity entity)
	{
		throw new NotImplementedException();
	}
}

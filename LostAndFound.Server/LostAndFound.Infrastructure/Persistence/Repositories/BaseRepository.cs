using Microsoft.EntityFrameworkCore;
using LostAndFound.Application.Interfaces.Repositories;
using LostAndFound.Domain.Entities;

namespace LostAndFound.Infrastructure.Persistence.Repositories;

internal class BaseRepository<TEntity>(LostAndFoundDbContext context)
	: IRepository<TEntity>
	where TEntity : Entity
{
	protected readonly LostAndFoundDbContext _context = context;

	public async Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken = default)
	{
		return await _context.Set<TEntity>()
			.AsNoTracking()
			.ToListAsync(cancellationToken);
	}

	public async Task<TEntity?> GetAsync(Guid id, CancellationToken cancellationToken = default)
	{
		return await _context.Set<TEntity>()
			.AsNoTracking()
			.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
	}

	public async Task AddAsync(TEntity entity, CancellationToken cancellationToken = default)
	{
		await _context.Set<TEntity>().AddAsync(entity, cancellationToken);
	}

	public void Update(TEntity entity)
	{
		_context.Set<TEntity>().Update(entity);
	}

	public void Delete(TEntity entity)
	{
		_context.Set<TEntity>().Remove(entity);
	}
}

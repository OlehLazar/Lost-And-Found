using LostAndFound.Domain.Entities;

namespace LostAndFound.Application.Interfaces.Repositories;

public interface IRepository<TEntity>
	where TEntity : Entity
{
	Task<TEntity?> GetAsync(Guid id, CancellationToken cancellationToken = default);

	Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken = default);

	Task AddAsync(TEntity entity, CancellationToken cancellationToken = default);

	void Update(TEntity entity);

	void Delete(TEntity entity);
}

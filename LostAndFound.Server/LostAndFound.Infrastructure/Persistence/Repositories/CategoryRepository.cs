using LostAndFound.Application.Interfaces.Repositories;
using LostAndFound.Domain.Entities;

namespace LostAndFound.Infrastructure.Persistence.Repositories;

internal class CategoryRepository(LostAndFoundDbContext context)
	: BaseRepository<Category>(context), ICategoryRepository
{
}

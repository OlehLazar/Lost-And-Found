using LostAndFound.Application.Interfaces.Repositories;
using LostAndFound.Domain.Entities;

namespace LostAndFound.Infrastructure.Persistence.Repositories;

internal class PostRepository(LostAndFoundDbContext context)
	: BaseRepository<Post>(context), IPostRepository
{
}

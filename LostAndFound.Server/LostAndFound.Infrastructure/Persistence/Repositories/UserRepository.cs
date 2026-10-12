using LostAndFound.Application.Interfaces.Repositories;
using LostAndFound.Domain.Entities;

namespace LostAndFound.Infrastructure.Persistence.Repositories;

internal class UserRepository(LostAndFoundDbContext context) 
	: BaseRepository<User>(context), IUserRepository
{
}

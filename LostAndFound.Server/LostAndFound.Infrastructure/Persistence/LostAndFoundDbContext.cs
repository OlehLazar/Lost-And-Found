using LostAndFound.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LostAndFound.Infrastructure.Persistence;

internal class LostAndFoundDbContext(DbContextOptions<LostAndFoundDbContext> options)
	: DbContext(options)
{
	public DbSet<User> Users { get; set; }

	public DbSet<Post> Posts { get; set; }

	public DbSet<Category> Categories { get; set; }
}

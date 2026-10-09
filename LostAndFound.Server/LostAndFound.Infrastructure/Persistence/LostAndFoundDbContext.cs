using LostAndFound.Domain.Entities;
using LostAndFound.Infrastructure.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace LostAndFound.Infrastructure.Persistence;

internal class LostAndFoundDbContext(DbContextOptions<LostAndFoundDbContext> options)
	: DbContext(options)
{
	public DbSet<User> Users { get; set; }

	public DbSet<Post> Posts { get; set; }

	public DbSet<Category> Categories { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.ApplyConfigurationsFromAssembly(AssemblyReference.Assembly);

		base.OnModelCreating(modelBuilder);
	}
}

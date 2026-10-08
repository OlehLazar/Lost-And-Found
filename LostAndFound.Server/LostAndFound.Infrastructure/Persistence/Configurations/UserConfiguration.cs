using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using LostAndFound.Domain.Entities;

namespace LostAndFound.Infrastructure.Persistence.Configurations;

internal class UserConfiguration : IEntityTypeConfiguration<User>
{
	public void Configure(EntityTypeBuilder<User> builder)
	{
		builder.HasKey(u => u.Id);

		builder.Property(u => u.UserName)
			.IsRequired();

		builder.Property(u => u.FirstName)
			.IsRequired();

		builder.Property(u => u.LastName)
			.IsRequired();

		builder.HasMany(u => u.Posts)
			.WithOne(p => p.Creator)
			.HasForeignKey(p => p.CreatorId)
			.OnDelete(DeleteBehavior.NoAction);
	}
}

using LostAndFound.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LostAndFound.Infrastructure.Persistence.Configurations;

internal class PostConfiguration : IEntityTypeConfiguration<Post>
{
	public void Configure(EntityTypeBuilder<Post> builder)
	{
		builder.HasKey(p => p.Id);

		builder.Property(p => p.Title)
			.IsRequired();

		builder.Property(p => p.Description)
			.IsRequired();

		builder.Property(p => p.Location)
			.IsRequired();

		builder.Property(p => p.Date)
			.IsRequired();

		builder.Property(p => p.Type)
			.IsRequired();

		builder.Property(p => p.Status)
			.IsRequired();

		builder.HasOne(p => p.Creator)
			.WithMany(c => c.Posts)
			.HasForeignKey(p => p.CreatorId)
			.OnDelete(DeleteBehavior.NoAction);

		builder.HasOne(p => p.Category)
			.WithMany(c => c.Posts)
			.HasForeignKey(p => p.CategoryId)
			.OnDelete(DeleteBehavior.NoAction);
	}
}

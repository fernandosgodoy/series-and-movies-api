using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviesCollection.Entities;

namespace MoviesCollection.EFPersistence.Configurations
{
    public class EpisodeConfiguration
        : IEntityTypeConfiguration<Episode>
    {
        public void Configure(EntityTypeBuilder<Episode> builder)
        {
            builder.ToTable("episodes");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .IsRequired(true);

            builder.Property(x => x.CreatedAt)
                .HasColumnName("created_at")
                .IsRequired(true);

            builder.Property(x => x.Deleted)
                .HasColumnName("deleted")
                .IsRequired(false);

            builder.Property(x => x.MovieId)
                .HasColumnName("movie_id")
                .IsRequired(true);

            builder.Property(x => x.Title)
                .HasColumnName("title")
                .HasMaxLength(70)
                .IsRequired(true);

            builder.Property(x => x.Slug)
                .HasColumnName("slug")
                .HasMaxLength(10)
                .IsRequired(true);

        }
    }
}

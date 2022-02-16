using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviesCollection.Entities;

namespace MoviesCollection.EFPersistence.Configurations
{
    public class MovieConfiguration
        : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.ToTable("movies");
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

            builder.Property(x => x.Title)
                .HasColumnName("title")
                .HasMaxLength(70)
                .IsRequired(true);

            builder.Property(x => x.CoverUrl)
                .HasColumnName("cover_url")
                .HasMaxLength(255)
                .IsRequired(false);

            builder.Property(x => x.Storyline)
                .HasColumnName("storyline")
                .HasMaxLength(800)
                .IsRequired(false);

            builder.Property(x => x.Languages)
                .HasColumnName("languages")
                .IsRequired(true);

            builder.Property(x => x.ReleaseDate)
                .HasColumnName("release_date")
                .IsRequired(true);

            builder.Property(x => x.Synopsis)
                .HasColumnName("synopsis")
                .HasMaxLength(8000)
                .IsRequired(false);

        }
    }
}

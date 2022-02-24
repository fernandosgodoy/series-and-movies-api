using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviesCollection.Entities;

namespace MoviesCollection.EFPersistence.Configurations
{
    public class ActorConfiguration
        : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.ToTable("actors");
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

            builder.Property(x => x.Name)
                .HasColumnName("name")
                .HasMaxLength(50)
                .IsRequired(true);

            builder.Property(x => x.Birthdate)
                .HasColumnName("birthdate")
                .IsRequired(true);

            builder.Property(x => x.Biography)
                .HasColumnName("biography")
                .HasMaxLength(800)
                .IsRequired(false);

            builder.Property(x => x.ImageUrl)
                .HasColumnName("image_url")
                .HasMaxLength(255)
                .IsRequired(true);

        }
    }
}

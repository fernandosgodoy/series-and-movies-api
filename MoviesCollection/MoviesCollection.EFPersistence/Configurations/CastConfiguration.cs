using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviesCollection.Entities;

namespace MoviesCollection.EFPersistence.Configurations
{
    public class CastConfiguration
        : IEntityTypeConfiguration<Cast>
    {
        public void Configure(EntityTypeBuilder<Cast> builder)
        {
            builder.ToTable("casts");

            builder.HasKey(c => new { c.ActorId, c.MovieId });

            builder.Property(x => x.ActorId)
                .HasColumnName("actor_id")
                .IsRequired(true);

            builder.Property(x => x.MovieId)
                .HasColumnName("movie_id")
                .IsRequired(true);

            builder.Property(x => x.Role)
                .HasColumnName("name")
                .HasMaxLength(50)
                .IsRequired(true);

            
        }
    }
}

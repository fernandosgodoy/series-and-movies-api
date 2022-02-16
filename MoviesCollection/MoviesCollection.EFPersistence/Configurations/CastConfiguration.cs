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

            builder.Property(x => x.Role)
                .HasColumnName("name")
                .HasMaxLength(50)
                .IsRequired(true);

        }
    }
}

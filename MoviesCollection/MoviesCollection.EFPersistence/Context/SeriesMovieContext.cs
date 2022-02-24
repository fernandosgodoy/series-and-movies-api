using Microsoft.EntityFrameworkCore;
using MoviesCollection.EFPersistence.Configurations;
using MoviesCollection.Entities;

namespace MoviesCollection.EFPersistence.Context
{
    public class SeriesMovieContext
        : DbContext
    {

        public SeriesMovieContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Actor>()
                .HasMany(a => a.Casts)
                .WithOne(c => c.Actor)
                .HasForeignKey(c => c.ActorId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Movie>()
                .HasMany(a => a.Casts)
                .WithOne(c => c.Movie)
                .HasForeignKey(c => c.MovieId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Movie>()
                .HasMany(mv => mv.Episodes)
                .WithOne(e => e.Movie)
                .HasForeignKey(e => e.MovieId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.ApplyConfiguration(new ActorConfiguration());
            modelBuilder.ApplyConfiguration(new CastConfiguration());
            modelBuilder.ApplyConfiguration(new EpisodeConfiguration());
            modelBuilder.ApplyConfiguration(new MovieConfiguration());
        }

    }
}

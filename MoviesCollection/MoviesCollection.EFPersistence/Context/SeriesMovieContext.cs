using Microsoft.EntityFrameworkCore;
using MoviesCollection.EFPersistence.Configurations;

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
            modelBuilder.ApplyConfiguration(new ActorConfiguration());
            modelBuilder.ApplyConfiguration(new CastConfiguration());
            modelBuilder.ApplyConfiguration(new EpisodeConfiguration());
            modelBuilder.ApplyConfiguration(new MovieConfiguration());
        }

    }
}

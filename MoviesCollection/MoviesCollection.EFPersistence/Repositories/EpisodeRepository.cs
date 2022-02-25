using MoviesCollection.EFPersistence.Context;
using MoviesCollection.Entities;

namespace MoviesCollection.EFPersistence.Repositories
{
    public class EpisodeRepository
        : RepositoryBase<Episode>
    {
        public EpisodeRepository(SeriesMovieContext db) : base(db)
        {
        }
    }
}

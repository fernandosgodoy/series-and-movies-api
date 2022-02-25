using MoviesCollection.EFPersistence.Context;
using MoviesCollection.Entities;

namespace MoviesCollection.EFPersistence.Repositories
{
    public class CastRepository
        : RepositoryBase<Cast>
    {
        public CastRepository(SeriesMovieContext db) : base(db)
        {
        }
    }
}

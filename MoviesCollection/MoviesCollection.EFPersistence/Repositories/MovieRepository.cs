using MoviesCollection.EFPersistence.Context;
using MoviesCollection.Entities;

namespace MoviesCollection.EFPersistence.Repositories
{
    public class MovieRepository
        : RepositoryBase<Movie>
    {
        public MovieRepository(SeriesMovieContext db) : base(db)
        {
        }
    }
}

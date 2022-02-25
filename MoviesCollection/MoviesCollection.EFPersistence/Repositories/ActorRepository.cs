using MoviesCollection.EFPersistence.Context;
using MoviesCollection.Entities;

namespace MoviesCollection.EFPersistence.Repositories
{
    public class ActorRepository
        : RepositoryBase<Actor>
    {
        public ActorRepository(SeriesMovieContext db) : base(db)
        {
        }
    }
}

using MoviesCollection.BusinessApp.Dtos.Messages;
using MoviesCollection.BusinessApp.Dtos.Movies;
using MoviesCollection.EFPersistence.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoviesCollection.BusinessApp.Maintenance
{
    public class MovieMaintenanceService
        : IApplicationMaintenance<MovieDto>
    {

        private readonly MovieRepository movieRepository;

        public MovieMaintenanceService(MovieRepository movieRepo)
        {
            this.movieRepository = movieRepo;
        }

        public Task<Result> DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<MovieDto> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Result> InsertAsync(MovieDto dtoEntry)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<MovieDto>> ListAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Result> UpdateAsync(int id, MovieDto dtoEntry)
        {
            throw new System.NotImplementedException();
        }
    }
}

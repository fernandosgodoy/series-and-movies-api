using Microsoft.EntityFrameworkCore;
using MoviesCollection.BusinessApp.Dtos.Messages;
using MoviesCollection.BusinessApp.Dtos.Movies;
using MoviesCollection.EFPersistence.Repositories;
using MoviesCollection.Entities;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<Result> DeleteAsync(int id)
        {
            var result = new Result();
            var entity = await this.movieRepository.All
                .Where(x => x.Id == id)
                .SingleOrDefaultAsync();

            if (entity == null)
            {
                result.Messages.Add("Not found.");
                return result;
            }

            await this.movieRepository.Delete(entity);
            result.Success = true;
            return result;
        }

        public async Task<MovieDto> GetByIdAsync(int id)
        {
            return await this.movieRepository.All
                .Where(x => x.Id == id)
                .Select(Movie.ToFullDto)
                .SingleOrDefaultAsync();
        }

        public async Task<Result> InsertAsync(MovieDto dtoEntry)
        {
            var result = new Result();
            var entity = new Movie(dtoEntry);
            await this.movieRepository.Add(entity);
            result.InsertedId = entity.Id;
            result.Success = (entity.Id > 0);
            return result;
        }

        public async Task<IEnumerable<MovieDto>> ListAllAsync()
        {
            return await this.movieRepository.All
                .Select(Movie.ToFullDto)
                .ToListAsync();
        }

        public async Task<Result> UpdateAsync(int id, MovieDto dtoEntry)
        {
            var result = new Result();
            var entity = new Movie(dtoEntry);
            entity.Id = id;
            await this.movieRepository.Update(entity);
            result.Success = true;
            return result;
        }
    }
}

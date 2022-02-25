using Microsoft.EntityFrameworkCore;
using MoviesCollection.BusinessApp.Dtos.Messages;
using MoviesCollection.EFPersistence.Context;
using MoviesCollection.EFPersistence.Repositories;
using MoviesCollection.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoviesCollection.BusinessApp.Maintenance
{
    public class ActorMaintenanceService
    {
        private readonly SeriesMovieContext context;
        private readonly ActorRepository actorRepository;

        public ActorMaintenanceService(SeriesMovieContext db,
            ActorRepository actorRepo)
        {
            this.context = db;
            this.actorRepository = actorRepo;
        }

        public async Task<IEnumerable<Actor>> ListAllConfigurations()
        {
            return await this.actorRepository.All
                .ToArrayAsync();
        }

        public async Task<Actor> GetConfigurationById(int id)
        {
            return await actorRepository.GetById(id);
        }

        public async Task<Result> InsertConfiguration(Actor actorEntry)
        {
            var result = new Result();
            await this.actorRepository.Add(actorEntry);
            result.InsertedId = actorEntry.Id;
            result.Success = (result.InsertedId > 0);
            return result;
        }

        public async Task<Result> UpdateConfiguration(int id, Actor actorEntry)
        {
            var result = new Result();
            actorEntry.Id = id; 
            await this.actorRepository.Update(actorEntry);
            result.Success = true;
            return result;
        }

        public async Task<Result> DeleteConfiguration(int id)
        {
            var result = new Result();
            var actor = await this.actorRepository.GetById(id);

            if (actor == null)
                return result;

            await this.actorRepository.Delete(actor);
            result.Success = true;
            return result;
        }
    }
}

using Microsoft.EntityFrameworkCore;
using MoviesCollection.BusinessApp.Dtos.Actors;
using MoviesCollection.BusinessApp.Dtos.Messages;
using MoviesCollection.EFPersistence.Repositories;
using MoviesCollection.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesCollection.BusinessApp.Maintenance
{
    public class ActorMaintenanceService
    {
        private readonly ActorRepository actorRepository;

        public ActorMaintenanceService(ActorRepository actorRepo)
        {
            this.actorRepository = actorRepo;
        }

        public async Task<IEnumerable<ActorDto>> ListAllAsync()
        {
            return await this.actorRepository.All
                .Select(Actor.ToFullDto)
                .ToArrayAsync();
        }

        public async Task<ActorDto> GetByIdAsync(int id)
        {
            return await actorRepository.All
                .Where(a => a.Id == id)
                .Select(Actor.ToFullDto)
                .SingleOrDefaultAsync();
        }

        public async Task<Result> InsertAsync(ActorDto actorEntry)
        {
            var result = new Result();
            await this.actorRepository.Add(new Actor(actorEntry));
            result.InsertedId = actorEntry.Id;
            result.Success = (result.InsertedId > 0);
            return result;
        }

        public async Task<Result> UpdateAsync(int id, ActorDto actorEntry)
        {
            var result = new Result();
            actorEntry.Id = id; 
            await this.actorRepository.Update(new Actor(actorEntry));
            result.Success = true;
            return result;
        }

        public async Task<Result> DeleteAsync(int id)
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

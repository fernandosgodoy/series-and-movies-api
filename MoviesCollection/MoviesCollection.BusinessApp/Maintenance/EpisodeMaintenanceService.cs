using Microsoft.EntityFrameworkCore;
using MoviesCollection.BusinessApp.Dtos.Episodes;
using MoviesCollection.BusinessApp.Dtos.Messages;
using MoviesCollection.EFPersistence.Repositories;
using MoviesCollection.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesCollection.BusinessApp.Maintenance
{
    public class EpisodeMaintenanceService
        : IApplicationMaintenance<EpisodeDto>
    {
        private readonly EpisodeRepository episodeRepository;

        public EpisodeMaintenanceService(EpisodeRepository episodeRepo)
        {
            this.episodeRepository = episodeRepo;
        }

        public async Task<Result> DeleteAsync(int id)
        {
            var result = new Result();
            var entity = await this.episodeRepository.All
                .Where(x => x.Id == id)
                .SingleOrDefaultAsync();

            if (entity == null)
            {
                result.Messages.Add("Not found.");
                return result;
            }

            await this.episodeRepository.Delete(entity);
            result.Success = true;
            return result;
        }

        public async Task<EpisodeDto> GetByIdAsync(int id)
        {
            return await this.episodeRepository.All
                .Where(x => x.Id == id)
                .Select(Episode.ToFullDto)
                .SingleOrDefaultAsync();
        }

        public async Task<Result> InsertAsync(EpisodeDto dtoEntry)
        {
            var result = new Result();
            var entity = new Episode(dtoEntry);
            await this.episodeRepository.Add(entity);
            result.InsertedId = entity.Id;
            result.Success = (entity.Id > 0);
            return result;
        }

        public async Task<IEnumerable<EpisodeDto>> ListAllAsync()
        {
            return await this.episodeRepository.All
                .Select(Episode.ToFullDto)
                .ToListAsync();
        }

        public async Task<Result> UpdateAsync(int id, EpisodeDto dtoEntry)
        {
            var result = new Result();
            var entity = new Episode(dtoEntry);
            entity.Id = id;
            await this.episodeRepository.Update(entity);
            result.Success = true;
            return result;
        }
    }
}

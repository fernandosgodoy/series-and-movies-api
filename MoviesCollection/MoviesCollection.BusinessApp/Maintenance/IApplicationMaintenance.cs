using MoviesCollection.BusinessApp.Dtos.Base;
using MoviesCollection.BusinessApp.Dtos.Messages;
using MoviesCollection.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoviesCollection.BusinessApp.Maintenance
{
    public interface IApplicationMaintenance<TDto>
        where TDto : DtoBase
    {
        Task<IEnumerable<TDto>> ListAllAsync();
        Task<TDto> GetByIdAsync(int id);
        Task<Result> InsertAsync(TDto dtoEntry);
        Task<Result> UpdateAsync(int id, TDto dtoEntry);
        Task<Result> DeleteAsync(int id);
    }
}

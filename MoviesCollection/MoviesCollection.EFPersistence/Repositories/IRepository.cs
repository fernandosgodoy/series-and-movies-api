using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesCollection.EFPersistence.Repositories
{
    public interface IRepository<TEntity>
        where TEntity : class
    {

        IQueryable<TEntity> All { get; }
        Task<TEntity> GetById(int id);
        Task Add(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(TEntity entity);

    }
}

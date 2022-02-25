using MoviesCollection.EFPersistence.Context;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesCollection.EFPersistence.Repositories
{
    public class RepositoryBase<TEntity>
        : IRepository<TEntity>
        where TEntity : class
    {

        private readonly SeriesMovieContext context;
        public RepositoryBase(SeriesMovieContext db)
        {
            this.context = db;
        }

        public IQueryable<TEntity> All =>
            this.context.Set<TEntity>().AsQueryable();

        public async Task Add(TEntity entity)
        {
            await this.context.Set<TEntity>().AddRangeAsync(entity);
            await this.context.SaveChangesAsync();
        }

        public async Task DeleteById(TEntity entity)
        {
            this.context.Set<TEntity>().RemoveRange(entity);
            await this.context.SaveChangesAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await this.context.FindAsync<TEntity>(id);
        }

        public async Task Update(TEntity entity)
        {
            this.context.Set<TEntity>().UpdateRange(entity);
            await this.context.SaveChangesAsync();
        }
    }
}

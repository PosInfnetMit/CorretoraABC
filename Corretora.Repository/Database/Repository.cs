using Corretora.Domain.Core.Interfaces.Repository;
using Corretora.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace Corretora.Repository.Database
{
    public class Repository<T> : IRepository<T>, IDisposable where T : class
    {

        protected DbSet<T> Query { get; set; }
        protected DbContext Context { get; set; }
        public Repository(CorretoraContext corretoraContext)
        {
            this.Context = corretoraContext;
            this.Query = Context.Set<T>();
        }

        public async Task Delete(T entity)
        {
            this.Query.Remove(entity);
            await this.Context.SaveChangesAsync();
        }

        public async Task<T> Get(object id)
        {
            return await this.Query.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll()

        {
            return await this.Query
                             .AsNoTrackingWithIdentityResolution()
                             .ToListAsync();
        }

        public async Task Save(T entity)
        {
            await this.Query.AddAsync(entity);
            await this.Context.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            this.Query.Update(entity);
            await this.Context.SaveChangesAsync();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

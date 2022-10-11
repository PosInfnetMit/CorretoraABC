namespace Corretora.Domain.Core.Interfaces.Repository
{
    public interface IRepository<T> where T : class 
    {
        Task Save(T entity);
        Task Delete(T entity);
        Task Update(T entity);
        Task<T> Get(object id);
        Task<IEnumerable<T>> GetAll();
    }
    
}

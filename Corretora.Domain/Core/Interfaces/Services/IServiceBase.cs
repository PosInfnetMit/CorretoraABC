namespace Corretora.Domain.Core.Interfaces.Services
{
    public interface IServiceBase<T> where T : class
    {
        Task Save(T entity);
        Task Delete(T entity);
        Task Update(T entity);
        Task<T> Get(object id);
        Task<IEnumerable<T>> GetAll();
    }
}

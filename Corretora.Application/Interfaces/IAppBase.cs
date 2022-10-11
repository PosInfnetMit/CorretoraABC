namespace Corretora.Application.Interfaces
{
    public interface IAppBase<T> where T : class
    {
        Task Save(T entity);
        Task Delete(T entity);
        Task Update(T entity);
        Task<T> Get(object id);
        Task<IEnumerable<T>> GetAll();
    }
}

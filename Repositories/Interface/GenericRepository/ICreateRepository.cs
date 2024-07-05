namespace Repositories.Interface.GenericRepository
{
    public interface ICreateRepository<T>
    {
        Task<T> Create(T entity);
    }
}

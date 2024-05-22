namespace Repositories.Interface.GenericRepository
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T?>?> GetAll();
        Task<T?> GetById(int id);
        Task<int> Create(T entity);
        Task<IEnumerable<T>> Find(Func<T, bool> predicate);
        Task<int> Update(int id, T entity);
    }
}

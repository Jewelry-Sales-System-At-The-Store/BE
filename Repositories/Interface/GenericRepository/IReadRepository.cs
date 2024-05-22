namespace Repositories.Interface.GenericRepository
{
    public interface IReadRepository<T>
    {
        Task<IEnumerable<T?>?> GetAll();
        Task<T?> GetById(int id);
    }
}

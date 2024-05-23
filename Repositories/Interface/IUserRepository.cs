using BusinessObjects.Models;
namespace Repositories.Interface
{
    public interface IUserRepository : IReadRepository<User>, IFindRepository<User>
    {
        public Task<User?> GetUser(string email, string password);
    }
}

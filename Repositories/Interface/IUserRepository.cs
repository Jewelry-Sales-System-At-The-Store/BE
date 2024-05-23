using BusinessObjects.Models;
using Repositories.Interface.GenericRepository;
namespace Repositories.Interface
{
    public interface IUserRepository : IReadRepository<User>, IFindRepository<User>
    {
        public Task<User?> GetUser(string email, string password);
    }
}

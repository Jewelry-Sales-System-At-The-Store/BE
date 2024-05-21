using BusinessObjects.Models;

namespace Repositories.Interface
{
    public interface IUserRepository : IRepository<User>
    {
        public Task<User?> GetUser(string email, string password);
    }
}

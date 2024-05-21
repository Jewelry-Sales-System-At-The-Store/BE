using BusinessObjects.Models;

namespace Services.Interface
{
    public interface IUserService
    {
        public Task<User> GetUser(string email, string password);
        public Task<IEnumerable<User>> GetUsers();
        public Task<bool> IsUser(string email, string password);
    }
}

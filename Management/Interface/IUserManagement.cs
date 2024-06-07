using BusinessObjects.DTO;
using BusinessObjects.Models;

namespace Management.Interface
{
    public interface IUserManagement
    {
        public Task<User?> Login(LoginDto loginDTO);
        public Task<IEnumerable<User?>?> GetUsers();
        public Task<bool> IsUser(string email, string password);
    }
}

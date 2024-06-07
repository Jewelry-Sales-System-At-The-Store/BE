using BusinessObjects.DTO;
using BusinessObjects.Models;

namespace Services.Interface
{
    public interface IUserService
    {
        public Task<User?> Login(LoginDto loginDTO);
        public Task<IEnumerable<User?>?> GetUsers();
        public Task<bool> IsUser(string email, string password);
    }
}

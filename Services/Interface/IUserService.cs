using BusinessObjects.Dto;
using BusinessObjects.Models;

namespace Services.Interface
{
    public interface IUserService
    {
        public Task<User?> Login(LoginDto loginDto);
        public Task<IEnumerable<User?>?> GetUsers();
        public Task<bool> IsUser(string email, string password);
    }
}

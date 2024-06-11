using BusinessObjects.Dto;
using BusinessObjects.Models;

namespace Services.Interface
{
    public interface IUserService
    {
        public Task<User?> Login(LoginDto loginDto);
        public Task<IEnumerable<User?>?> GetUsers();
        public Task<bool> IsUser(string email, string password);
        public Task<int> AddUser(UserDto userDto);
        public Task<int> UpdateUser(string id, UserDto userDto);
        public Task<User?> GetUserById(string id);
        
        public Task<int> DeleteUser(string id);
    }
}

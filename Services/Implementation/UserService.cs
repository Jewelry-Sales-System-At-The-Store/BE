using BusinessObjects.Models;
using Repositories.Interface;
using Services.Interface;

namespace Services.Implementation
{
    public class UserService(IUserRepository userRepository) : IUserService
    {
        public IUserRepository UserRepository { get; } = userRepository;

        public async Task<User> GetUser(string email, string password)
        {
            return await UserRepository.GetUser(email, password);
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await UserRepository.GetAll();
        }

        public async Task<bool> IsUser(string email, string password)
        {
            var users = await UserRepository.Find(a => a.Email == email && a.Password == password);
            return users.Any();
        }
    }
}

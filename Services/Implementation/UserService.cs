using BusinessObjects.Dto;
using BusinessObjects.Models;
using Repositories.Interface;
using Services.Interface;

namespace Services.Implementation
{
    public class UserService(IUserRepository userRepository) : IUserService
    {
        public IUserRepository UserRepository { get; } = userRepository;

        public async Task<User?> Login(LoginDto loginDto)
        {
            return await UserRepository.GetUser(loginDto.Email ?? "", loginDto.Password ?? "");
        }

        public async Task<IEnumerable<User?>?> GetUsers()
        {
            return await UserRepository.Gets();
        }

        public async Task<bool> IsUser(string email, string password)
        {
            var users = await UserRepository.Find(a => a.Email == email && a.Password == password);
            return users.Any();
        }
    }
}

using AutoMapper;
using BusinessObjects.Dto;
using BusinessObjects.Models;
using Repositories.Interface;
using Services.Interface;

namespace Services.Implementation
{
    public class UserService(IUserRepository userRepository, IMapper mapper) : IUserService
    {
        public IUserRepository UserRepository { get; } = userRepository;
        public IMapper Mapper { get; } = mapper;

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
        
        public async Task<int> UpdateUser(string id, UserDto userDto)
        {
            var user = Mapper.Map<User>(userDto);
            return await UserRepository.Update(id, user);
        }

        public async Task<int> AddUser(UserDto userDto)
        {
            var user = Mapper.Map<User>(userDto);
            return await UserRepository.Create(user);
        }

        public Task<User?> GetUserById(string id)
        {
            return UserRepository.GetById(id);
        }

        public Task<int> DeleteUser(string id)
        {
            return UserRepository.Delete(id);
        }
    }
}

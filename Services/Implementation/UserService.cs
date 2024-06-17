using AutoMapper;
using BusinessObjects.DTO;
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
            var user = await UserRepository.GetUser(loginDto.Email ?? "", loginDto.Password ?? "");
            return user ?? null;
        }

        public async Task<IEnumerable<User?>?> GetUsers()
        {
            return await UserRepository.Gets();
        }

        public async Task<bool> IsUser(LoginDto loginDto)
        {
            var users = await UserRepository.Find(a => a.Email == loginDto.Email && a.Password == loginDto.Password);
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

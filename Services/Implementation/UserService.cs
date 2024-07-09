using AutoMapper;
using BusinessObjects.Dto;
using BusinessObjects.Dto.ResponseDto;
using BusinessObjects.Models;
using Repositories.Interface;
using Services.Interface;
namespace Services.Implementation;

public class UserService(IUserRepository userRepository, IMapper mapper) : IUserService
{
    private IUserRepository UserRepository { get; } = userRepository;
    private IMapper Mapper { get; } = mapper;

    public async Task<User?> Login(LoginDto loginDto)
    {
        var user = await UserRepository.GetUser(loginDto.Email ?? "", loginDto.Password ?? "");
        return user ?? null;
    }

    public async Task<IEnumerable<UserResponseDto?>> GetUsers()
    {
        var users = await UserRepository.Gets();
        var userResponseDtos = Mapper.Map<IEnumerable<UserResponseDto>>(users);

        foreach (var userResponseDto in userResponseDtos)
        {
            var user = await UserRepository.GetById(userResponseDto.UserId);
            userResponseDto.CounterNumber = user?.Counter?.Number;
            userResponseDto.RoleName = user?.Role?.RoleName;
        }

        return userResponseDtos;
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

    public async Task<UserResponseDto?> GetUserById(string id)
    {
        var user = await UserRepository.GetById(id);
        var userResponseDto = Mapper.Map<UserResponseDto>(user);
        userResponseDto.CounterNumber = user?.Counter?.Number;
        userResponseDto.RoleName = user.Role.RoleName;
        return userResponseDto;
    }

    public Task<int> DeleteUser(string id)
    {
        return UserRepository.Delete(id);
    }
}

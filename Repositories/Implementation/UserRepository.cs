using BusinessObjects.Models;
using DAO;
using Repositories.Interface;

namespace Repositories.Implementation
{
    public class UserRepository(UserDao userDao, RoleDao roleDao) : IUserRepository
    {
        public UserDao UserDao { get; } = userDao;
        public RoleDao RoleDao { get; } = roleDao;

        public Task<IEnumerable<User>> Find(Func<User, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<User?> GetUser(string email, string password)
        {
            return await UserDao.GetUser(email, password);
        }

        public async Task<User?> GetById(string id)
        {
            var user = await UserDao.GetUserById(id);
            var role = await RoleDao.GetRoleById(user.RoleId);
            user.Role = role;
            return user;
        }

        public async Task<int> Update(string id, User entity)
        {
           return await UserDao.UpdateUser(id, entity);
        }

        public async Task<IEnumerable<User?>?> Gets()
        {
            var users = await UserDao.GetUsers();
            foreach (var user in users)
            {
                var userRole = await RoleDao.GetRoleById(user.RoleId);
                user.Role = userRole;
            }
            return users;
        }

        public async Task<int> Create(User entity)
        {
            return await UserDao.CreateUser(entity);
        }
        public async Task<int> Delete(string id)
        {
            return await UserDao.DeleteUser(id);
        }
    }
}

using BusinessObjects.Models;
using DAO;
using Repositories.Interface;

namespace Repositories.Implementation
{
    public class UserRepository : IUserRepository
    {
        

        public Task<IEnumerable<User>> Find(Func<User, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<User?> GetUser(string email, string password)
        {
            return await UserDao.Instance.GetUser(email, password);
        }

        public async Task<User?> GetById(string id)
        {
            var user = await UserDao.Instance.GetUserById(id);
            user.Role = await RoleDao.Instance.GetRoleById(user.RoleId);
            return user;
        }

        public async Task<int> Update(string id, User entity)
        {
           return await UserDao.Instance.UpdateUser(id, entity);
        }

        public async Task<IEnumerable<User?>?> Gets()
        {
            var users = await UserDao.Instance.GetUsers();
            foreach (var user in users)
            {
                var userRole = await RoleDao.Instance.GetRoleById(user.RoleId);
                user.Role = userRole;
            }
            return users;
        }

        public async Task<int> Create(User entity)
        {
            return await UserDao.Instance.CreateUser(entity);
        }
        public async Task<int> Delete(string id)
        {
            return await UserDao.Instance.DeleteUser(id);
        }
    }
}

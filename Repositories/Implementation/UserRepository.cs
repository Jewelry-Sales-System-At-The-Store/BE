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
            return await UserDAO.Instance.GetUser(email, password);
        }

        public async Task<User?> GetById(int id)
        {
            return await UserDAO.Instance.GetUserById(id);
        }

        public Task<int> Update(int id, User entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User?>?> GetAll()
        {
            return await UserDAO.Instance.GetUsers();
        }

        public Task<int> Create(User entity)
        {
            throw new NotImplementedException();
        }
    }
}

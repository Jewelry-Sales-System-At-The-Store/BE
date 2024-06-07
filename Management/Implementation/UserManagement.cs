using BusinessObjects.DTO;
using BusinessObjects.Models;
using Management.Interface;
using Repositories.Interface;

namespace Management.Implementation
{
    public class UserManagement : IUserManagement
    {
        public Task<User?> Login(LoginDTO loginDTO)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User?>?> GetUsers()
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsUser(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}

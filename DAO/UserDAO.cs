using BusinessObjects.Models;
using DAO.Context;
using DAO.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public class UserDAO : Singleton<UserDAO>
    {
        private readonly JssatsV2Context _context;

        public UserDAO()
        {
            _context = new JssatsV2Context();
        }

        public async Task<User?> GetUser(string email, string password)
        {
            return await _context.Users.FirstOrDefaultAsync(p => p.Email == email && p.Password == password);
        }
        public async Task<IEnumerable<User?>?> GetUsers()
        {
            return await _context.Users.Include(u=>u.Role).Include(u=>u.Purchases).ToListAsync();
        }
        public async Task<User?> GetUserById(int id)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}

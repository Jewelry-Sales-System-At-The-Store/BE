using BusinessObjects.Models;
using Repositories.Interface.GenericRepository;
namespace Repositories.Interface
{
    public interface IUserRepository : IReadRepository<User>, IFindRepository<User>, ICreateRepository<User>, IUpdateRepository<User>, IDeleteRepository<User>
    {
        public Task<User?> GetUser(string email, string password);
        Task<User?> GetUserById(string id);
        Task<IEnumerable<string>> GetAvailableCounters();
        Task<bool> AssignCounterToUser(User user, string counterId);
        Task<bool> ReleaseCounterFromUser(User user);
    }
}

using BusinessObjects.Models;

namespace Repositories.Interface
{
    public interface ICustomerRepository : IReadRepository<Customer>, ICreateRepository<Customer>, IUpdateRepository<Customer>
    {
    }
}

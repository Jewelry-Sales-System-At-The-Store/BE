using BusinessObjects.Models;
using Repositories.Interface.GenericRepository;

namespace Repositories.Interface
{
    public interface ICustomerRepository : IReadRepository<Customer>, ICreateRepository<Customer>, IUpdateRepository<Customer>, IDeleteRepository<Customer>
    {
        Task<(int,int,IEnumerable<Customer>)> GetsPaging(int pageNumber, int pageSize);
        Task<Customer?> GetCustomerByPhone(string phoneNumber);
        Task<Customer> CreateCustomer(Customer entity);
        Task<int> GetTotalCustomers();
        Task<int> GetNewCustomers(DateTime startDate, DateTime endDate);
        Task<int> GetRepeatCustomers();
        Task<int> GetActiveCustomers(DateTime startDate, DateTime endDate);
    }
}

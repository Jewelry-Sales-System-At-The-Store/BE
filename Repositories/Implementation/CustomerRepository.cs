using BusinessObjects.Models;
using DAO;
using Repositories.Interface;

namespace Repositories.Implementation
{
    public class CustomerRepository(CustomerDao customerDao) : ICustomerRepository
    {
        public CustomerDao CustomerDao { get; } = customerDao;

        public async Task<int> Create(Customer entity)
        {
            return await CustomerDao.CreateCustomer(entity);
        }

        public Task<IEnumerable<Customer>> Find(Func<Customer, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Customer?>?> Gets()
        {
            return await CustomerDao.GetCustomers();
        }

        public async Task<Customer?> GetById(string id)
        {
            return await CustomerDao.GetCustomerById(id);
        }

        public Task<int> Update(string id, Customer entity)
        {
            return CustomerDao.UpdateCustomer(id, entity);
        }
    }
}

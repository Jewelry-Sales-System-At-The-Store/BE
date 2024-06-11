using BusinessObjects.Models;
using DAO;
using Repositories.Interface;

namespace Repositories.Implementation
{
    public class CustomerRepository : ICustomerRepository
    {
        public async Task<int> Create(Customer entity)
        {
            return await CustomerDao.Instance.CreateCustomer(entity);
        }

        public Task<IEnumerable<Customer>> Find(Func<Customer, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Customer?>?> Gets()
        {
            return await CustomerDao.Instance.GetCustomers();
        }

        public async Task<Customer?> GetById(string id)
        {
            return await CustomerDao.Instance.GetCustomerById(id);
        }

        public Task<int> Update(string id, Customer entity)
        {
            return CustomerDao.Instance.UpdateCustomer(id, entity);
        }
    }
}

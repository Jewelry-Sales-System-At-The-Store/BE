using BusinessObjects.Models;
using DAO;
using Repositories.Interface;

namespace Repositories.Implementation
{
    public class CustomerRepository : ICustomerRepository
    {
        public async Task<int> Create(Customer entity)
        {
            return await CustomerDAO.Instance.CreateCustomer(entity);
        }

        public Task<IEnumerable<Customer>> Find(Func<Customer, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Customer?>?> GetAll()
        {
            return await CustomerDAO.Instance.GetCustomers();
        }

        public async Task<Customer?> GetById(int id)
        {
            return await CustomerDAO.Instance.GetCustomerById(id);
        }

        public Task<int> Update(int id, Customer entity)
        {
            return CustomerDAO.Instance.UpdateCustomer(id, entity);
        }
    }
}

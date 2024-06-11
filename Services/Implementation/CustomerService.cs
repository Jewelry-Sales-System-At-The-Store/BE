using BusinessObjects.Models;
using Repositories.Interface;
using Services.Interface;

namespace Services.Implementation
{
    public class CustomerService(ICustomerRepository customerRepository) : ICustomerService
    {
        public ICustomerRepository CustomerRepository { get; } = customerRepository;

        public async Task<int> CreateCustomer(Customer customer)
        {
            return await CustomerRepository.Create(customer);
        }

        public Task<int> DeleteCustomer(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<Customer?> GetCustomerById(string id)
        {
            return await CustomerRepository.GetById(id);
        }

        public async Task<IEnumerable<Customer?>?> GetCustomers()
        {
            return await CustomerRepository.Gets();
        }

        public async Task<int> UpdateCustomer(string id, Customer customer)
        {
            return await CustomerRepository.Update(id, customer);
        }
    }
}

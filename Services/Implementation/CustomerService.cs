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

        public Task<int> DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Customer?> GetCustomerById(int id)
        {
            return await CustomerRepository.GetById(id);
        }

        public async Task<IEnumerable<Customer?>?> GetCustomers()
        {
            return await CustomerRepository.GetAll();
        }

        public async Task<int> UpdateCustomer(int id, Customer customer)
        {
            return await CustomerRepository.Update(id, customer);
        }
    }
}

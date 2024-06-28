using BusinessObjects.Models;
using DAO;
using Repositories.Interface;

namespace Repositories.Implementation
{
    public class CustomerRepository(CustomerDao customerDao) : ICustomerRepository
    {
        private CustomerDao CustomerDao { get; } = customerDao;

        public async Task<Customer> CreateCustomer(Customer entity)
        {
            entity.Point = 0;
            return await CustomerDao.CreateCustomer(entity);
        }

        public async Task<(int,int,IEnumerable<Customer>)> GetsPaging(int pageNumber, int pageSize)
        {
            var (totalRecord, totalPage, customers) = await CustomerDao.GetCustomersPaging(pageNumber, pageSize);
            return (totalRecord, totalPage, customers);
        }

        public async Task<Customer?> GetCustomerByPhone(string phoneNumber)
        {
            return await CustomerDao.GetCustomerByPhone(phoneNumber);
        }

        public async Task<IEnumerable<Customer>?> Gets()
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

        public async Task<int> Delete(string id)
        {
            return await CustomerDao.DeleteCustomer(id);
        }

        public Task<int> Create(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
using BusinessObjects.DTO.Other;
using BusinessObjects.Models;
using Repositories.Interface.GenericRepository;

namespace Repositories.Interface
{
    public interface ICustomerRepository : IReadRepository<Customer>, ICreateRepository<Customer>, IUpdateRepository<Customer>, IDeleteRepository<Customer>
    {
        Task<(int,int,IEnumerable<Customer>)> GetsPaging(int pageNumber, int pageSize);
    }
}

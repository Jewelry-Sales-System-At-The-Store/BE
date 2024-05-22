using BusinessObjects.DTO;
using BusinessObjects.Models;
using Repositories.Interface.GenericRepository;
namespace Repositories.Interface
{
    public interface IBillRepository : IReadRepository<Bill>, ICreateRepository<BillDTO>
    {
        public Task<Bill?> FindBillByCustomerId(int customerId);
    }
}

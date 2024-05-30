using BusinessObjects.DTO;
using BusinessObjects.Models;
using Repositories.Interface.GenericRepository;

namespace Repositories.Interface;
public interface IBillRepository : IReadRepository<Bill>, ICreateRepository<BillDTO>
{
    public Task<Bill?> FindBillByCustomerId(int customerId);
    public Task<BillResponseDTO?> GetById2(int id);
    public Task<IEnumerable<BillResponseDTO?>?> GetAll2();
}

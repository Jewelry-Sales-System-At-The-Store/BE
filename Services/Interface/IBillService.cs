using BusinessObjects.DTO;
using BusinessObjects.Models;

namespace Services.Interface
{
    public interface IBillService
    {
        public Task<int> Create(BillDTO entity);
        public Task<Bill?> FindBillByCustomerId(int customerId);
        public Task<IEnumerable<BillResponseDTO?>?> GetAll();
        public Task<BillResponseDTO?> GetById(int id);
    }
}

using BusinessObjects.DTO;
using BusinessObjects.Models;

namespace Services.Interface
{
    public interface IBillService
    {
        public Task<int> Create(BillDTO entity);
        public Task<Bill?> FindBillByCustomerId(int customerId);
        public Task<IEnumerable<Bill?>?> GetAll();
        public Task<Bill?> GetById(int id);
        public Task<BillResponseDTO?> GetById2(int id);
        public Task<IEnumerable<BillResponseDTO?>?> GetAll2();
    }
}

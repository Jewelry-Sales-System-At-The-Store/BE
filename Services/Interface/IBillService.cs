using BusinessObjects.DTO;
using BusinessObjects.Models;

namespace Services.Interface
{
    public interface IBillService
    {
        public Task<int> Create(BillDto entity);
        public Task<IEnumerable<Bill?>?> GetAll();
        public Task<Bill?> GetById(int id);
    }
}

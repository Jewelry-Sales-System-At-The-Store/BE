using BusinessObjects.DTO.Bill;
using BusinessObjects.DTO.BillReqRes;
using BusinessObjects.Models;

namespace Services.Interface
{
    public interface IBillService
    {
        public Task<BillResponseDto> Create(BillRequestDto entity);
        public Task<IEnumerable<BillDetailDto?>?> GetBills();
        public Task<BillDetailDto?> GetById(string id);
    }
}

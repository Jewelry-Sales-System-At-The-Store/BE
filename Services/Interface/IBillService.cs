using BusinessObjects.DTO.Bill;
using BusinessObjects.DTO.BillReqRes;
using BusinessObjects.DTO.Other;

namespace Services.Interface
{
    public interface IBillService
    {
        public Task<BillResponseDto> Create(BillRequestDto entity);
        public Task<PagingResponse> GetBills(int pageNumber, int pageSize);
        public Task<BillDetailDto?> GetById(string id);
    }
}

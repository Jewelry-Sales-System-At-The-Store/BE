using BusinessObjects.DTO.BillReqRes;
using BusinessObjects.DTO.Other;

namespace Repositories.Implementation;

public interface IBillDetailRepository
{
    Task AddBillDetail(BillDetailDto billDetail);
    Task<PagingResponse> GetBillDetails(int pageNumber, int pageSize);
    Task<BillDetailDto> GetBillDetail(string billId);
}
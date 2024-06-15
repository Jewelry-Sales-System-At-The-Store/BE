using BusinessObjects.DTO.Bill;
using BusinessObjects.Models;
using Repositories.Interface.GenericRepository;

namespace Repositories.Interface;

public interface IBillRepository : IReadRepository<Bill>
{
    public Task<BillResponseDto> CreateBill(BillRequestDto billRequestDto);
}

using BusinessObjects.DTO.Bill;
using BusinessObjects.Models;
using Repositories.Interface;
using Services.Interface;

namespace Services.Implementation
{ 
    public class BillService(IBillRepository billRepository) : IBillService
    {
        private IBillRepository BillRepository { get; } = billRepository;

        public async Task<BillResponseDto> Create(BillRequestDto billRequestDto)
        {
            return await BillRepository.CreateBill(billRequestDto);
        }
        
        public async Task<IEnumerable<Bill?>?> GetBills()
        {
            return await BillRepository.Gets();
        }

        public async Task<Bill?> GetById(string id)
        {
            return await BillRepository.GetById(id);
        }
    }
}

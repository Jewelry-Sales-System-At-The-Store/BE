using BusinessObjects.DTO;
using BusinessObjects.Models;
using Repositories.Interface;
using Services.Interface;

namespace Services.Implementation
{
    public class BillService(IBillRepository billRepository) : IBillService
    {
        private readonly IBillRepository billRepository = billRepository;

        public IBillRepository BillRepository => billRepository;
        public async Task<int> Create(BillDTO entity)
        {
            return await billRepository.Create(entity);
        }

        public async Task<Bill?> FindBillByCustomerId(int customerId)
        {
            return await billRepository.FindBillByCustomerId(customerId);
        }

        public async Task<IEnumerable<BillResponseDTO?>?> GetAll()
        {
            return await billRepository.GetAll();
        }

        public async Task<BillResponseDTO?> GetById(int id)
        {
            return await billRepository.GetById(id);
        }
    }
}

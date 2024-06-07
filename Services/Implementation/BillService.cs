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
        public async Task<int> Create(BillDto entity)
        {
            return await billRepository.Create(entity);
        }
        

        public async Task<IEnumerable<Bill?>?> GetAll()
        {
            return await billRepository.GetAll();
        }

        public async Task<Bill?> GetById(int id)
        {
            return await billRepository.GetById(id);
        }
    }
}

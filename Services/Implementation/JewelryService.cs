using BusinessObjects.DTO;
using BusinessObjects.Models;
using Repositories.Interface;
using Services.Interface;

namespace Services.Implementation
{
    public class JewelryService : IJewelryService
    {
        private readonly IJewelryRepository _jewelryRepository;
        public JewelryService(IJewelryRepository jewelryRepository)
        {
            _jewelryRepository = jewelryRepository;
        }

        public async Task<int> CreateJewelry(Jewelry jewelry)
        {
            return await _jewelryRepository.Create(jewelry);
        }

        public Task<int> DeleteJewelry(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Jewelry?>?> GetJewelries()
        {
            return await _jewelryRepository.GetAll();
        }

        public async Task<Jewelry?> GetJewelryById(int id)
        {
            return await _jewelryRepository.GetById(id);
        }
        public async Task<int> UpdateJewelry(int id, Jewelry jewelry)
        {
            return await _jewelryRepository.Update(id, jewelry);
        }
    }
}

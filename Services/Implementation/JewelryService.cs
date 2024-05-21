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

        public Task<int> CreateJewelry(Jewelry jewelry)
        {
            return _jewelryRepository.CreateJewelry(jewelry);
        }

        public Task<int> DeleteJewelry(int id)
        {
            return _jewelryRepository.DeleteJewelry(id);
        }

        public Task<IEnumerable<Jewelry>> GetJewelries()
        {
            return _jewelryRepository.GetJewelries();
        }

        public Task<Jewelry> GetJewelryById(int id)
        {
            return _jewelryRepository.GetJewelryById(id);
        }

        public Task<int> UpdateJewelry(Jewelry jewelry)
        {
            return _jewelryRepository.UpdateJewelry(jewelry);
        }
    }
}

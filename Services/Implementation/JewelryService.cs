using BusinessObjects.DTO.ResponseDto;
using BusinessObjects.Models;
using Repositories.Interface;
using Services.Interface;

namespace Services.Implementation
{
    public class JewelryService(IJewelryRepository jewelryRepository) : IJewelryService
    {
        private IJewelryRepository JewelryRepository { get; } = jewelryRepository;

        public async Task<IEnumerable<JewelryResponseDto?>?> GetJewelries()
        {
            var jewelries = await JewelryRepository.Gets();
            return jewelries;
        }

        public async Task<JewelryResponseDto?> GetJewelryById(string id)
        {
            var jewelryResponseDto = await JewelryRepository.GetById(id);
            return jewelryResponseDto;
        }


        public async Task<int> CreateJewelry(Jewelry jewelry)
        {
            return await JewelryRepository.Create(jewelry);
        }

        public Task<int> DeleteJewelry(string id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<int> UpdateJewelry(string id, Jewelry jewelry)
        {
            return await JewelryRepository.Update(id, jewelry);
        }

    }
}

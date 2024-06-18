using BusinessObjects.DTO.Jewelry;
using BusinessObjects.DTO.ResponseDto;
using BusinessObjects.Models;

namespace Services.Interface
{
    public interface IJewelryService
    {
        public Task<IEnumerable<JewelryResponseDto?>?> GetJewelries();
        public Task<JewelryResponseDto?> GetJewelryById(string id);
        public Task<int> CreateJewelry(JewelryRequestDto jewelryRequestDto);
        public Task<int> UpdateJewelry(string id, Jewelry jewelry);
        public Task<int> DeleteJewelry(string id);
    }
}

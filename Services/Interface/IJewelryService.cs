using BusinessObjects.DTO;
using BusinessObjects.Models;

namespace Services.Interface
{
    public interface IJewelryService
    {
        public Task<IEnumerable<JewelryResponseDTO?>?> GetJewelries();
        public Task<JewelryResponseDTO?> GetJewelryById(int id);
        public Task<int> CreateJewelry(Jewelry jewelry);
        public Task<int> UpdateJewelry(int id, Jewelry jewelry);
        public Task<int> DeleteJewelry(int id);
    }
}

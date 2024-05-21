using BusinessObjects.Models;

namespace Services.Interface
{
    public interface IJewelryService
    {
        public Task<IEnumerable<Jewelry>> GetJewelries();
        public Task<Jewelry> GetJewelryById(int id);
        public Task<int> CreateJewelry(Jewelry jewelry);
        public Task<int> UpdateJewelry(Jewelry jewelry);
        public Task<int> DeleteJewelry(int id);
    }
}

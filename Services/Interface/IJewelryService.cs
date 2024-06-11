using BusinessObjects.Models;

namespace Services.Interface
{
    public interface IJewelryService
    {
        public Task<IEnumerable<Jewelry?>?> GetJewelries();
        public Task<Jewelry?> GetJewelryById(string id);
        public Task<int> CreateJewelry(Jewelry jewelry);
        public Task<int> UpdateJewelry(string id, Jewelry jewelry);
        public Task<int> DeleteJewelry(string id);
    }
}

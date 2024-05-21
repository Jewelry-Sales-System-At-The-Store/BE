using BusinessObjects.DTO;
using BusinessObjects.Models;
using DAO;
using Repositories.Interface;

namespace Repositories.Implementation
{
    public class JewelryRepository : IJewelryRepository
    {
        public Task<int> CreateJewelry(Jewelry jewelry)
        {
            return JewelryDAO.Instance.CreateJewelry(jewelry);
        }

        public Task<int> DeleteJewelry(int id)
        {
            return JewelryDAO.Instance.DeleteJewelry(id);
        }

        public Task<IEnumerable<Jewelry>> GetJewelries()
        {
            return JewelryDAO.Instance.GetJewelries();
        }

        public Task<Jewelry> GetJewelryById(int id)
        {
            return JewelryDAO.Instance.GetJewelryById(id);
        }

        public Task<int> UpdateJewelry(Jewelry jewelry)
        {
            throw new NotImplementedException();
        }
    }
}

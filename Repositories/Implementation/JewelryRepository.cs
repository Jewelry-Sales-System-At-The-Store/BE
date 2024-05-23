using BusinessObjects.Models;
using DAO;
using Repositories.Interface;

namespace Repositories.Implementation
{
    public class JewelryRepository : IJewelryRepository
    {
        public async Task<int> Create(Jewelry entity)
        {
            return await JewelryDAO.Instance.CreateJewelry(entity);
        }

        public async Task<int> Delete(int id)
        {
            return await JewelryDAO.Instance.DeleteJewelry(id);
        }

        public async Task<IEnumerable<Jewelry?>?> GetAll()
        {
            return await JewelryDAO.Instance.GetJewelries();
        }

        public async Task<Jewelry?> GetById(int id)
        {
            return await JewelryDAO.Instance.GetJewelryById(id);
        }

        public async Task<int> Update(int id, Jewelry entity)
        {
            return await JewelryDAO.Instance.UpdateJewelry(id, entity);
        }
    }
}

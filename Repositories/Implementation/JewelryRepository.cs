using AutoMapper;
using BusinessObjects.Models;
using DAO;
using Repositories.Interface;

namespace Repositories.Implementation
{
    public class JewelryRepository(IMapper mapper) : IJewelryRepository
    {
        public IMapper Mapper { get; } = mapper;

        public async Task<int> Create(Jewelry entity)
        {
            entity.IsSold = false;
            return await JewelryDAO.Instance.CreateJewelry(entity);
        }

        public async Task<int> Delete(int id)
        {
            return await JewelryDAO.Instance.DeleteJewelry(id);
        }

        public async Task<IEnumerable<Jewelry?>?> GetAll()
        {
            var jewelries = await JewelryDAO.Instance.GetJewelries();
            foreach (var jewelry in jewelries)
            {
                var jewelryType = await JewelryTypeDAO.Instance.GetJewelryTypeById(jewelry.JewelryTypeId);
                jewelry.JewelryType = jewelryType;
            }
            return jewelries;
        }

        public async Task<Jewelry?> GetById(int id)
        {
            var jewelry = await JewelryDAO.Instance.GetJewelryById(id);
            var jewelryType = await JewelryTypeDAO.Instance.GetJewelryTypeById(jewelry?.JewelryTypeId);
            if (jewelry == null) return null;
            jewelry.JewelryType = jewelryType;
            return jewelry;
        }

        public async Task<int> Update(int id, Jewelry entity)
        {
            return await JewelryDAO.Instance.UpdateJewelry(id, entity);
        }
    }
}

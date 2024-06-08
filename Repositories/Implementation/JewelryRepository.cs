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
            return await JewelryDao.Instance.CreateJewelry(entity);
        }

        public async Task<int> Delete(int id)
        {
            return await JewelryDao.Instance.DeleteJewelry(id);
        }

        public async Task<IEnumerable<Jewelry?>?> Gets()
        {
            var jewelries = await JewelryDao.Instance.GetJewelries();
            foreach (var jewelry in jewelries)
            {
                var jewelryType = await JewelryTypeDao.Instance.GetJewelryTypeById(jewelry.JewelryTypeId);
                jewelry.JewelryType = jewelryType;
            }
            return jewelries;
        }

        public async Task<Jewelry?> GetById(int id)
        {
            var jewelry = await JewelryDao.Instance.GetJewelryById(id);
            var jewelryType = await JewelryTypeDao.Instance.GetJewelryTypeById(jewelry?.JewelryTypeId);
            if (jewelry == null) return null;
            jewelry.JewelryType = jewelryType;
            return jewelry;
        }

        public async Task<int> Update(int id, Jewelry entity)
        {
            return await JewelryDao.Instance.UpdateJewelry(id, entity);
        }
    }
}

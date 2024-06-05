using AutoMapper;
using BusinessObjects.DTO;
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
            return await JewelryDAO.Instance.CreateJewelry(entity);
        }

        public async Task<int> Delete(int id)
        {
            return await JewelryDAO.Instance.DeleteJewelry(id);
        }

        public async Task<IEnumerable<Jewelry?>?> GetAll()
        {
            var jewelries =  await JewelryDAO.Instance.GetJewelries();
            return jewelries;
        }

        public async Task<Jewelry?> GetById(int id)
        {
            var jewelry = await JewelryDAO.Instance.GetJewelryById(id);
            return jewelry;
        }

        public async Task<int> Update(int id, Jewelry entity)
        {
            return await JewelryDAO.Instance.UpdateJewelry(id, entity);
        }
    }
}

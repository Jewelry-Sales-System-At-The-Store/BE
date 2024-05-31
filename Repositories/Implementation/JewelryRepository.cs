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

        public async Task<IEnumerable<JewelryResponseDTO?>?> GetAll()
        {
            var jewelries = JewelryDAO.Instance.GetJewelries();
            if (jewelries == null) return null;
            var jewelryResponses = new List<JewelryResponseDTO?>();
            foreach (var Jewelry in await jewelries)
            {
                var jewelryResponse = Mapper.Map<JewelryResponseDTO>(Jewelry);
                jewelryResponses.Add(jewelryResponse);
            }
            return jewelryResponses;
        }

        public async Task<JewelryResponseDTO?> GetById(int id)
        {
            var Jewelry = await JewelryDAO.Instance.GetJewelryById(id);
            return Mapper.Map<JewelryResponseDTO>(Jewelry);
        }

        public async Task<int> Update(int id, Jewelry entity)
        {
            return await JewelryDAO.Instance.UpdateJewelry(id, entity);
        }
    }
}

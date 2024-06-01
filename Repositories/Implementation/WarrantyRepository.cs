using AutoMapper;
using BusinessObjects.DTO;
using BusinessObjects.Models;
using DAO;
using Repositories.Interface;

namespace Repositories.Implementation
{
    public class WarrantyRepository(IMapper mapper) : IWarrantyRepository
    {
        public IMapper Mapper { get; } = mapper;

        public async Task<int> Create(Warranty entity)
        {
            return await WarrantyDAO.Instance.CreateWarranty(entity);
        }

        public Task<IEnumerable<Warranty>> Find(Func<Warranty, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<WarrantyResponseDTO?>?> GetAll()
        {
            var warranties = WarrantyDAO.Instance.GetWarranties();
            if (warranties == null) return null;
            var warrantyResponses = new List<WarrantyResponseDTO?>();
            foreach (var warranty in await warranties)
            {
                var warrantyResponse = Mapper.Map<WarrantyResponseDTO>(warranty);
                warrantyResponses.Add(warrantyResponse);
            }
            return warrantyResponses;
        }

        public async Task<WarrantyResponseDTO?> GetById(int id)
        {
            var warranty = await WarrantyDAO.Instance.GetWarrantyById(id);
            return Mapper.Map<WarrantyResponseDTO>(warranty); 
        }

        public async Task<int> Update(int id, Warranty entity)
        {
            return await WarrantyDAO.Instance.UpdateWarranty(id, entity);
        }
    }
}

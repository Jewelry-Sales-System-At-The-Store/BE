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

        public async Task<IEnumerable<Warranty?>?> GetAll()
        {
            var warranties =  await WarrantyDAO.Instance.GetWarranties();
            return warranties;
        }

        public async Task<Warranty?> GetById(int id)
        {
            var warranty = await WarrantyDAO.Instance.GetWarrantyById(id);
            return warranty;
        }

        public async Task<int> Update(int id, Warranty entity)
        {
            return await WarrantyDAO.Instance.UpdateWarranty(id, entity);
        }
    }
}

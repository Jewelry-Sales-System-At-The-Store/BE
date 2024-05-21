using BusinessObjects.Models;
using DAO;
using Repositories.Interface;

namespace Repositories.Implementation
{
    public class WarrantyRepository : IWarrantyRepository
    {
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
            return await WarrantyDAO.Instance.GetWarranties();
        }

        public async Task<Warranty?> GetById(int id)
        {
            return await WarrantyDAO.Instance.GetWarrantyById(id);
        }

        public async Task<int> Update(int id, Warranty entity)
        {
            return await WarrantyDAO.Instance.UpdateWarranty(id, entity);
        }
    }
}

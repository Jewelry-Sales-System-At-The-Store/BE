using BusinessObjects.Models;
using DAO;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<IEnumerable<Warranty>> GetAll()
        {
            return await WarrantyDAO.Instance.GetWarranties();
        }

        public async Task<Warranty> GetById(int id)
        {
            return await WarrantyDAO.Instance.GetWarrantyById(id);
        }

        public Task<Warranty> Update(Warranty entity)
        {
            throw new NotImplementedException();
        }
    }
}

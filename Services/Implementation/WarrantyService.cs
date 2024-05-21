using BusinessObjects.Models;
using Repositories.Interface;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementation
{
    public class WarrantyService(IWarrantyRepository warrantyRepository) : IWarrantyService
    {
        public IWarrantyRepository WarrantyRepository { get; } = warrantyRepository;

        public Task<int> CreateWarranty(Warranty warranty)
        {
            return WarrantyRepository.Create(warranty);
        }

        public Task<int> DeleteWarranty(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Warranty?>?> GetWarranties()
        {
            return await WarrantyRepository.GetAll();
        }

        public async Task<Warranty?> GetWarrantyById(int id)
        {
            return await WarrantyRepository.GetById(id);
        }

        public async Task<int> UpdateWarranty(int id,Warranty warranty)
        {
            return await WarrantyRepository.Update(id,warranty);
        }
    }
}

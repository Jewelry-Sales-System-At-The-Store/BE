using BusinessObjects.DTO;
using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IWarrantyService
    {
        public Task<int> CreateWarranty(Warranty warranty);
        public Task<IEnumerable<WarrantyResponseDTO?>?> GetWarranties();
        public Task<WarrantyResponseDTO?> GetWarrantyById(int id);
        public Task<int> UpdateWarranty(int id ,Warranty warranty);
        public Task<int> DeleteWarranty(int id);
    }
}

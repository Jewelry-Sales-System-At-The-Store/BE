using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
    public interface IJewelryRepository
    {
        public Task<IEnumerable<Jewelry>> GetJewelries();
        public Task<Jewelry> GetJewelryById(int id);
        public Task<int> CreateJewelry(Jewelry jewelry);
        public Task<int> UpdateJewelry(Jewelry jewelry);
        public Task<int> DeleteJewelry(int id);
    }
}

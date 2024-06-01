using BusinessObjects.Models;
using DAO.Context;
using DAO.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public class WarrantyDAO : Singleton<WarrantyDAO>
    {
        private readonly JssatsV2Context _context;

        public WarrantyDAO()
        {
            _context = new JssatsV2Context();
        }
        public async Task<IEnumerable<Warranty>?> GetWarranties()
        {
            return await _context.Warranties
                                 .Include(w => w.Jewelries)
                                    .ThenInclude(jt => jt.JewelryType)
                                 .ToListAsync();
        }
        public async Task<Warranty?> GetWarrantyById(int? id)
        {
            return await _context.Warranties.Include(w => w.Jewelries).FirstOrDefaultAsync(w=>w.WarrantyId == id);
        }
        public async Task<int> CreateWarranty(Warranty warranty)
        {
            var maxWarrantyId = await _context.Warranties.MaxAsync(w => w.WarrantyId);
            warranty.WarrantyId = maxWarrantyId + 1;
            _context.Warranties.Add(warranty);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateWarranty(int id, Warranty warranty)
        {
            var existingWarranty = await _context.Warranties
                .FirstOrDefaultAsync(w => w.WarrantyId == id);
            warranty.WarrantyId = id;
            if (existingWarranty == null) return 0;
            _context.Entry(existingWarranty).CurrentValues.SetValues(warranty);
            _context.Entry(existingWarranty).State = EntityState.Modified;

            return await _context.SaveChangesAsync();
        }
        public async Task<int> DeleteWarranty(int id)
        {
            var warranty = await _context.Warranties.FindAsync(id);
            if (warranty != null)
            {
                _context.Warranties.Remove(warranty);
                return await _context.SaveChangesAsync();
            }
            return 0;
        }
    }
}

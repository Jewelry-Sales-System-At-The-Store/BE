using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public class WarrantyDAO
    {
        private readonly JssatsV2Context _context;
        public static WarrantyDAO? instance;
        public WarrantyDAO()
        {
            _context = new JssatsV2Context();
        }
        public static WarrantyDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new WarrantyDAO();
                }
                return instance;
            }
        }
        public async Task<IEnumerable<Warranty>> GetWarranties()
        {
            return await _context.Warranties
                                 .Include(w => w.Jewelries)
                                 .ToListAsync();
        }
        public async Task<Warranty> GetWarrantyById(int id)
        {
            return await _context.Warranties.FindAsync(id) ?? new Warranty();
        }
        public async Task<int> CreateWarranty(Warranty warranty)
        {
            var maxWarrantyId = await _context.Warranties.MaxAsync(w => w.WarrantyId);
            warranty.WarrantyId = maxWarrantyId + 1;
            _context.Warranties.Add(warranty);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateWarranty(Warranty warranty)
        {
            var existingWarranty = await _context.Warranties
                .AsNoTracking()
                .FirstOrDefaultAsync(w => w.WarrantyId == warranty.WarrantyId);
            if (existingWarranty == null)
            {
                _context.Warranties.Add(warranty);
            }
            else
            {
                _context.Entry(warranty).State = EntityState.Modified;
            }
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

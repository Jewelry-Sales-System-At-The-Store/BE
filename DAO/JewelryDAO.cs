using BusinessObjects.Models;
using DAO.Context;
using DAO.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public class JewelryDAO : Singleton<JewelryDAO>
    {
        private readonly JssatsV2Context _context;
        public JewelryDAO()
        {
            _context = new JssatsV2Context();
        }
        public async Task<IEnumerable<Jewelry>> GetJewelries()
        {
            return await _context.Jewelries.Include(j => j.JewelryType).ToListAsync();
        }

        public async Task<Jewelry> GetJewelryById(int id)
        {
            return await _context.Jewelries.FindAsync(id) ?? new Jewelry();
        }

        public async Task<int> CreateJewelry(Jewelry jewelry)
        {
            var maxJewelryId = await _context.Jewelries.MaxAsync(j => j.JewelryId);
            jewelry.JewelryId = maxJewelryId + 1;
            _context.Jewelries.Add(jewelry);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateJewelry(int id, Jewelry jewelry)
        {
            var existingJewelry = await _context.Jewelries
                .FirstOrDefaultAsync(w => w.JewelryId == id);
            jewelry.JewelryId = id;
            if (existingJewelry == null) return 0;
            _context.Entry(existingJewelry).CurrentValues.SetValues(jewelry);
            _context.Entry(existingJewelry).State = EntityState.Modified;
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteJewelry(int id)
        {
            var jewelry = await _context.Jewelries.FindAsync(id);
            _context.Jewelries.Remove(jewelry ?? new Jewelry());
            return await _context.SaveChangesAsync();
        }
        public async Task<bool> IsSold(int id)
        {
            var jewelry = await _context.Jewelries.FindAsync(id);
            return jewelry?.IsSold ?? false;
        }
        public async Task<IEnumerable<Jewelry>> GetJewelriesByBillId(int? billId)
        {
            return await _context.Jewelries
                .Where(j => j.BillJewelries.Any(bj => bj.BillId == billId))
                .ToListAsync();
        }

    }
}

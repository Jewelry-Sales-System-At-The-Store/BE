using BusinessObjects.Context;
using BusinessObjects.Models;
using DAO.Interfaces;
using Microsoft.EntityFrameworkCore;
using Tools;

namespace DAO
{
    public class JewelryDao : Singleton<JewelryDao>
    {
        private readonly JssatsContext _context;
        public JewelryDao()
        {
            _context = new JssatsContext();
        }
        public async Task<IEnumerable<Jewelry>> GetJewelries()
        {
            return await _context.Jewelries.ToListAsync();
        }

        public async Task<Jewelry?> GetJewelryById(string id)
        {
            return await _context.Jewelries.FirstOrDefaultAsync(p => p.JewelryId == id);
        }

        public async Task<int> CreateJewelry(Jewelry jewelry)
        {
            jewelry.JewelryId = IdGenerator.GenerateId();
            _context.Jewelries.Add(jewelry);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateJewelry(string id, Jewelry jewelry)
        {
            var existingJewelry = await _context.Jewelries
                .FirstOrDefaultAsync(w => w.JewelryId == id);
            jewelry.JewelryId = id;
            if (existingJewelry == null) return 0;
            _context.Entry(existingJewelry).CurrentValues.SetValues(jewelry);
            _context.Entry(existingJewelry).State = EntityState.Modified;
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteJewelry(string id)
        {
            var jewelry = await _context.Jewelries.FindAsync(id);
            _context.Jewelries.Remove(jewelry);
            return await _context.SaveChangesAsync();
        }
        public async Task<bool> IsSold(int id)
        {
            var jewelry = await _context.Jewelries.FindAsync(id);
            return jewelry?.IsSold ?? false;
        }
        public async Task<IEnumerable<Jewelry>> GetJewelriesByBillId(string billId)
        {
            return await _context.Jewelries
                .Where(j => j.BillJewelries.Any(bj => bj.BillId == billId))
                .ToListAsync();
        }
    }
}

using BusinessObjects.Models;
using DAO.Context;
using DAO.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace DAO
{
    public class BillJewelryDAO : Singleton<BillJewelryDAO>
    {
        private readonly JssatsV2Context _context;
        public BillJewelryDAO()
        {
            _context = new JssatsV2Context();
        }
        public async Task<IEnumerable<BillJewelry?>?> GetBillJewelries()
        {
            return await _context.BillJewelries.ToListAsync();
        }
        public async Task<BillJewelry?> GetBillJewelryById(int id)
        {
            return await _context.BillJewelries.FindAsync(id);
        }
        public async Task<int> CreateBillJewelry(BillJewelry billJewelry)
        {
            var maxBillJewelryId = await _context.BillJewelries.MaxAsync(b => b.BillJewelryId);
            billJewelry.BillJewelryId = maxBillJewelryId + 1;
            _context.BillJewelries.Add(billJewelry);
            return await _context.SaveChangesAsync();
        }
    }
}

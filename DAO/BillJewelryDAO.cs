using BusinessObjects.Context;
using BusinessObjects.Models;
using DAO.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace DAO
{
    public class BillJewelryDAO : Singleton<BillJewelryDAO>
    {
        private readonly JssatsContext _context;
        public BillJewelryDAO()
        {
            _context = new JssatsContext();
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
            _context.BillJewelries.Add(billJewelry);
            return await _context.SaveChangesAsync();
        }
        public async Task<BillJewelry?> GetBillJewelryByBillId(int billId)
        {
            return await _context.BillJewelries.FirstOrDefaultAsync(b => b.BillId == billId);
        } 
    }
}

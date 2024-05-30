using BusinessObjects.Models;
using DAO.Context;
using DAO.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public class BillDAO : Singleton<BillDAO>
    {
        private readonly JssatsV2Context _context;
        public BillDAO()
        {
            _context = new JssatsV2Context();
        }
        public async Task<IEnumerable<Bill?>?> GetBills()
        {
            return await _context.Bills.Include(b=>b.BillJewelries).ThenInclude(bj=>bj.Jewelry).ToListAsync();

            // Hello
        }
        public async Task<Bill?> GetBillById(int id)
        {
            return await _context.Bills.Include(b => b.BillJewelries).FirstOrDefaultAsync(b=>b.BillId == id);
        }
        public async Task<int> CreateBill(Bill bill)
        {
            var maxBillId = await _context.Bills.MaxAsync(b => b.BillId);
            bill.BillId = maxBillId + 1;
            _context.Bills.Add(bill);
            return await _context.SaveChangesAsync();
        }
        public async Task<Bill?> FindBillByCustomerId(int customerId)
        {
            return await _context.Bills.FirstOrDefaultAsync(b => b.CustomerId == customerId);
        }
    }
}

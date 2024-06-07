using BusinessObjects.Context;
using BusinessObjects.Models;
using DAO.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public class BillDAO : Singleton<BillDAO>
    {
        private readonly JssatsContext _context;
        public BillDAO()
        {
            _context = new JssatsContext();
        }
        public async Task<IEnumerable<Bill>> GetBills()
        {
            return await _context.Bills
                                 .Include(b => b.BillJewelries)
                                     .ThenInclude(bj => bj.Jewelry)
                                         .ThenInclude(j => j.JewelryType)
                                 .Include(b => b.Customer)
                                 .ToListAsync();
        }
        public async Task<Bill?> GetBillById(int id)
        {
            return await _context.Bills
                             .Include(b => b.BillJewelries)
                                 .ThenInclude(bj => bj.Jewelry)
                                     .ThenInclude(j => j.JewelryType)
                             .FirstOrDefaultAsync(b => b.BillId == id);
        }

        public async Task<Bill?> FindBillByCustomerId(int customerId)
        {
            return await _context.Bills
                                 .Include(b => b.BillJewelries)
                                     .ThenInclude(bj => bj.Jewelry)
                                         .ThenInclude(j => j.JewelryType)
                                 .Include(b => b.Customer)
                                 .FirstOrDefaultAsync(b => b.CustomerId == customerId);
        }

        public async Task<int> CreateBill(Bill bill)
        {
            _context.Bills.Add(bill);
            return await _context.SaveChangesAsync();
        }
    }
}

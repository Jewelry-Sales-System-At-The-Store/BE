using BusinessObjects.Context;
using BusinessObjects.Models;
using DAO.Interfaces;
using Microsoft.EntityFrameworkCore;
using Tools;

namespace DAO
{
    public class BillDao
    {
        private readonly JssatsContext _context = new();
        public async Task<IEnumerable<Bill>> GetBills()
        {
            return await _context.Bills.ToListAsync();
        }

        public async Task<Bill?> GetBillById(string id)
        {
            return await _context.Bills.FindAsync(id);
        }

        public async Task<string> CreateBill(Bill bill)
        {
            bill.BillId = IdGenerator.GenerateId();
            _context.Bills.Add(bill);
            await _context.SaveChangesAsync();
            return bill.BillId;
        }
    }
}

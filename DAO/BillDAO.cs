﻿using BusinessObjects.Models;
using DAO.Context;
using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public class BillDAO
    {
        private readonly JssatsV2Context _context;
        public static BillDAO? instance;
        public BillDAO()
        {
            _context = new JssatsV2Context();
        }
        public static BillDAO Instance
        {
            get
            {
                instance ??= new BillDAO();
                return instance;
            }
        }
        public async Task<IEnumerable<Bill?>?> GetBills()
        {
            return await _context.Bills.ToListAsync();
        }
        public async Task<Bill?> GetBillById(int id)
        {
            return await _context.Bills.FindAsync(id);
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

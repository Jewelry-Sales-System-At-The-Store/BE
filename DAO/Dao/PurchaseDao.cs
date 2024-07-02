using BusinessObjects.Context;
using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using Tools;

namespace DAO.Dao;

public class PurchaseDao
{
    private readonly JssatsContext _context;
    public PurchaseDao()
    {
        _context = new JssatsContext();
    }
    public async Task<IEnumerable<Purchase>> GetPurchases()
    {
        return await _context.Purchases.ToListAsync();
    }

    public async Task<Purchase?> GetPurchaseById(int id)
    {
        return await _context.Purchases.FindAsync(id);
    }
    public async Task<Purchase> CreatePurchase(Purchase purchase)
    {
        purchase.PurchaseId = Generator.GenerateId();
        _context.Purchases.Add(purchase);
        await _context.SaveChangesAsync();
        return purchase;
    }
    public async Task<Purchase> UpdatePurchase(int id, Purchase purchase)
    {
        _context.Entry(purchase).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return purchase;
    }
}
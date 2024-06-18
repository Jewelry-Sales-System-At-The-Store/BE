using BusinessObjects.Context;
using BusinessObjects.Models;
using DAO.Interfaces;
using Microsoft.EntityFrameworkCore;
using Tools;

namespace DAO;

public class BillPromotionDao
{
    private readonly JssatsContext _context;
    public BillPromotionDao()
    {
        _context = new JssatsContext();
    }
    public async Task<IEnumerable<BillPromotion?>?> GetBillPromotions()
    {
        return await _context.BillPromotions.ToListAsync();
    }
    public async Task<BillPromotion?> GetBillPromotionById(string id)
    {
        return await _context.BillPromotions.FindAsync(id);
    }
    public async Task<int> CreateBillPromotion(BillPromotion billPromotion)
    {
        billPromotion.BillPromotionId = IdGenerator.GenerateId();
        _context.BillPromotions.Add(billPromotion);
        return await _context.SaveChangesAsync();
    }
}
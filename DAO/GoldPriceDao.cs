using BusinessObjects.Context;
using BusinessObjects.Models;
using DAO.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAO;

public class GoldPriceDao : Singleton<GoldPriceDao>
{
    private readonly JssatsContext _context;
    public GoldPriceDao()
    {
        _context = new JssatsContext();
    }
    public async Task<IEnumerable<GoldPrice>> GetGoldPrices()
    {
        return await _context.GoldPrices.ToListAsync();
    }
    public async Task<int> Create(GoldPrice goldPrice)
    {
        _context.GoldPrices.Add(goldPrice);
        return await _context.SaveChangesAsync();
    }
    public async Task<int> Update(GoldPrice goldPrice)
    {
        _context.GoldPrices.Update(goldPrice);
        return await _context.SaveChangesAsync();
    }
}
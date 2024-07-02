using BusinessObjects.Context;
using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;

namespace DAO.Dao;

public class CounterDao
{
    private readonly JssatsContext _context;

    public CounterDao()
    {
        _context = new JssatsContext();
    }
    public async Task<IEnumerable<Counter>> GetCounters()
    {
        return await _context.Counters.ToListAsync();
    }
    public async Task<Counter> GetCounterById(string id)
    {
        return await _context.Counters.FindAsync(id);
    }
}
using BusinessObjects.Context;
using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using Tools;

namespace DAO;

public class CounterDao
{
    private readonly JssatsContext _context = new();

    public async Task<IEnumerable<Counter>> GetCounters()
    {
        return await _context.Counters.ToListAsync();
    }

    public async Task<Counter?> GetCounterById(string id)
    {
        return await _context.Counters.FindAsync(id);
    }

    public async Task<int> CreateCounter(Counter counter)
    {
        counter.CounterId = Generator.GenerateId();
        _context.Counters.Add(counter);
        return await _context.SaveChangesAsync();
    }

    public async Task<int> UpdateCounter(string id, Counter counter)
    {
        return await _context.SaveChangesAsync();
    }
}
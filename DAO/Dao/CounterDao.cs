using BusinessObjects.Context;
using BusinessObjects.Dto.Counter;
using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using Tools;

namespace DAO.Dao;

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

    public async Task<int> UpdateCounter(string id, UpdateCounter counter)
    {
        var existingCounter = await _context.Counters.FindAsync(id);
        if (existingCounter == null)
        {
            return 0;
        }

        existingCounter.Number = counter.Number;
        existingCounter.CreatedAt = counter.CreatedAt;
        existingCounter.UpdatedAt = counter.UpdatedAt;

        return await _context.SaveChangesAsync();
    }

    public async Task<int> DeleteCounter(string id)
    {
        var counter = await _context.Counters.FindAsync(id);
        if (counter == null)
        {
            return 0;
        }

        _context.Counters.Remove(counter);
        return await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Counter>> GetAvailableCounters()
    {
        var availableCounters = await _context.Counters
            .Where(c => !c.IsOccupied)
            .ToListAsync();
        return availableCounters;
    }
}
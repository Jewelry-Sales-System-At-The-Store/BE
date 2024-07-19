using BusinessObjects.Context;
using BusinessObjects.DTO;
using BusinessObjects.Dto.Counter;
using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using Tools;

namespace DAO.Dao;

public class CounterDao
{
    private readonly JssatsContext _context = new();
    private readonly IMongoCollection<CounterStatus> _counterCollection;

    public CounterDao(IMongoClient client, IConfiguration configuration)
    {
        var databaseName = configuration.GetSection("MongoDb:DatabaseName:JSSATS").Value;
        var database = client.GetDatabase(databaseName);
        _counterCollection = database.GetCollection<CounterStatus>("CounterStatuses");
    }
    
    public async Task<CounterStatus?> GetCounterById(string counterId)
    {
        return await _counterCollection.Find(c => c.CounterId == counterId).FirstOrDefaultAsync();
    }

    public async Task AddCounter(CounterStatus counter)
    {
        counter.Id = Generator.GenerateId();
        await _counterCollection.InsertOneAsync(counter);
    }
    public async Task<IEnumerable<CounterStatus>> GetAvailableCountersv2()
    {
        return await _counterCollection.Find(c => !c.IsOccupied).ToListAsync();
    }
    
    public async Task<IEnumerable<Counter>> GetCounters()
    {
        return await _context.Counters.ToListAsync();
    }

    public async Task<Counter?> GetCounterByIdv2(string id)
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
    
    public async Task UpdateCounterStatus(string counterId, bool isOccupied)
    {
        var filter = Builders<CounterStatus>.Filter.Eq(c => c.CounterId, counterId);
        var update = Builders<CounterStatus>.Update.Set(c => c.IsOccupied, isOccupied);
        await _counterCollection.UpdateOneAsync(filter, update);
    }

}
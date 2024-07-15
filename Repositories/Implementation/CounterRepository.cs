using BusinessObjects.Dto.Counter;
using BusinessObjects.Models;
using DAO;
using DAO.Dao;
using Repositories.Interface;
using Tools;

namespace Repositories.Implementation;

public class CounterRepository(CounterDao counterDao) : ICounterRepository
{
    private CounterDao CounterDao { get; } = counterDao;

    public async Task<IEnumerable<Counter>?> Gets()
    {
        return await CounterDao.GetCounters();
    }

    public async Task<Counter?> GetById(string id)
    {
       return await CounterDao.GetCounterById(id); 
    }

    public async Task<int> Create(CounterDto entity)
    {
        var counter = new Counter
        {
            CounterId = Generator.GenerateId(),
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow,
            Number = entity.Number,
        };
        return await CounterDao.CreateCounter(counter);
    }

    public async Task<int> Delete(string id)
    {
        return await CounterDao.DeleteCounter(id);
    }

    public async Task<int> Update(string id, UpdateCounter entity)
    {
        return await CounterDao.UpdateCounter(id, entity);
    }

    public async Task<IEnumerable<Counter>> GetAvailableCounters()
    {
        return await CounterDao.GetAvailableCounters();
    }
}
using BusinessObjects.Models;
using DAO;
using DAO.Dao;
using Repositories.Interface;

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
}
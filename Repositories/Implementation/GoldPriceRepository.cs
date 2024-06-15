using BusinessObjects.Models;
using DAO;
using Repositories.Interface;

namespace Repositories.Implementation;

public class GoldPriceRepository(GoldPriceDao goldPriceDao) : IGoldPriceRepository
{
    public GoldPriceDao GoldPriceDao { get; } = goldPriceDao;

    public async Task<IEnumerable<GoldPrice?>?> Gets()
    {
        return await GoldPriceDao.GetGoldPrices();
    }

    public Task<GoldPrice?> GetById(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<int> Create(GoldPrice entity)
    {
        return await GoldPriceDao.Create(entity);
    }

    public async Task<int> Update(GoldPrice entity)
    {
        return await GoldPriceDao.Update(entity);
    }
}
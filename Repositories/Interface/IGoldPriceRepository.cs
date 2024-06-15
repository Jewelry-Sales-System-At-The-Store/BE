using BusinessObjects.Models;
using Repositories.Interface.GenericRepository;

namespace Repositories.Interface;

public interface IGoldPriceRepository : IReadRepository<GoldPrice> , ICreateRepository<GoldPrice>
{
    Task<int> Update(GoldPrice entity);
}
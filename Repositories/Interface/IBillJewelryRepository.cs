using BusinessObjects.Dto.Dashboard;
using BusinessObjects.Models;
using Repositories.Interface.GenericRepository;

namespace Repositories.Interface;

public interface IBillJewelryRepository : ICreateRepository<BillJewelry>
{
    Task<IEnumerable<BestSellingProductDto>> GetBestSellingProducts();
    Task<IEnumerable<BestSellingProductTypeDto>> GetBestSellingProductTypes();
    Task<IEnumerable<ProductRevenueDto>> GetTotalRevenueByProducts();
    Task<IEnumerable<ProductTypeRevenueDto>> GetTotalRevenueByProductTypes();

}
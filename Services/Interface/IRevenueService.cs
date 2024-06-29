using BusinessObjects.Dto.Revenue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IRevenueService
    {
        Task<RevenueDto> GetTotalRevenue(DateTime startDate, DateTime endDate);
        Task<RevenueByCounterDto> GetRevenueByCounter(string counterId);
        Task<RevenueByEmployeeDto> GetRevenueByEmployee(string userId);
        Task<RevenueByProductTypeDto> GetRevenueByProductType(string typeId);
    }
}

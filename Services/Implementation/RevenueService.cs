using BusinessObjects.Dto.Revenue;
using Repositories.Interface;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementation
{
    public class RevenueService : IRevenueService
    {
        private readonly IBillRepository _billRepository;

        public RevenueService(IBillRepository billRepository)
        {
            _billRepository = billRepository;
        }
        public async Task<RevenueDto> GetTotalRevenueAllTime()
        {
            var totalRevenue = await _billRepository.GetTotalRevenueAllTime();
            return new RevenueDto { TotalRevenue = totalRevenue };
        }

        public async Task<RevenueDto> GetTotalRevenue(DateTime startDate, DateTime endDate)
        {
            var totalRevenue = await _billRepository.GetTotalRevenue(startDate, endDate);
            return new RevenueDto { TotalRevenue = totalRevenue };
        }

        public async Task<RevenueByCounterDto> GetRevenueByCounter(string counterId)
        {
            return await _billRepository.GetRevenueByCounter(counterId);
        }

        public async Task<RevenueByEmployeeDto> GetRevenueByEmployee(string userId)
        {
            return await _billRepository.GetRevenueByEmployee(userId);
        }

        public async Task<RevenueByProductTypeDto> GetRevenueByProductType(string typeId)
        {
            return await _billRepository.GetRevenueByProductType(typeId);
        }
    }
}

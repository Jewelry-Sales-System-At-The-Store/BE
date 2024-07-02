using BusinessObjects.Dto.Revenue;
using Repositories.Implementation;
using Repositories.Interface;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementation
{
    public class DashboardService : IDashboardService
    {
        private readonly IBillRepository _billRepository;
        private readonly ICustomerRepository _customerRepository;

        public DashboardService(IBillRepository billRepository, ICustomerRepository customerRepository)
        {
            _billRepository = billRepository;
            _customerRepository = customerRepository;
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

        public async Task<int> GetTotalCustomers()
        {
            return await _customerRepository.GetTotalCustomers();
        }

        public async Task<int> GetNewCustomers(DateTime startDate, DateTime endDate)
        {
            return await _customerRepository.GetNewCustomers(startDate, endDate);
        }

        public async Task<int> GetRepeatCustomers()
        {
            return await _customerRepository.GetRepeatCustomers();
        }

        public async Task<int> GetActiveCustomers(DateTime startDate, DateTime endDate)
        {
            return await _customerRepository.GetActiveCustomers(startDate, endDate);
        }
    }
}

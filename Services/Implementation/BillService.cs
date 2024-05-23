﻿using API.Extentions;
using BusinessObjects.DTO;
using BusinessObjects.Models;
using Repositories.Interface;
using Services.Interface;

namespace Services.Implementation
{
    public class BillService(IBillRepository billRepository) : IBillService
    {
        private readonly IBillRepository billRepository = billRepository;

        public IBillRepository BillRepository => billRepository;
        public async Task<int> Create(BillDTO entity)
        {
            return await billRepository.Create(entity);
        }

        public async Task<Bill?> FindBillByCustomerId(int customerId)
        {
            return await billRepository.FindBillByCustomerId(customerId);
        }

        public async Task<IEnumerable<Bill?>?> GetAll()
        {
            return await billRepository.GetAll();
        }

        public async Task<IEnumerable<BillResponseDTO?>?> GetAll2()
        {
            return await billRepository.GetAll2();
        }

        public async Task<Bill?> GetById(int id)
        {
            return await billRepository.GetById(id);
        }
        public async Task<BillResponseDTO?> GetById2(int id)
        {
            return await billRepository.GetById2(id);
        }
    }
}

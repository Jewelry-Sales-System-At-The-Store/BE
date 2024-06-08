using AutoMapper;
using BusinessObjects.Dto.Bill;
using BusinessObjects.Models;
using DAO;
using Repositories.Interface;

namespace Repositories.Implementation
{
    public class BillRepository : IBillRepository
    {

        // public async Task<int> Create(BillDto entity)
        // {
        //     if(entity.JewelryIds == null) return 0;
        //     var bill = new Bill
        //     {
        //         CustomerId = entity.CustomerId,
        //         UserId = entity.UserId,
        //         SaleDate = entity.SaleDate,
        //     };
        //     var result = await BillDao.Instance.CreateBill(bill);
        //     if (result <= 0) return result;
        //     foreach (var jewelryId in entity.JewelryIds)
        //     {
        //         var isSold = await JewelryDao.Instance.IsSold(jewelryId);
        //         if (isSold)
        //         {
        //             return 0;
        //         }
        //         var billJewelry = new BillJewelry
        //         {
        //             BillId = bill.BillId,
        //             JewelryId = jewelryId
        //         };
        //         result = await BillJewelryDao.Instance.CreateBillJewelry(billJewelry);
        //     }
        //     return result;
        // }
        public async Task<IEnumerable<Bill?>?> Gets()
        {
            return await BillDao.Instance.GetBills();
        }

        public async Task<Bill?> GetById(int id)
        {
            return await BillDao.Instance.GetBillById(id);
        }
        
        public async Task<BillResponseDto> CreateBill(BillRequestDto billRequestDto)
        {
            double totalAmount = 999;
            double totalDiscount = 0;
            double finalAmount = 0;
            
            // Create bill
            var bill = new Bill
            {
                CustomerId = billRequestDto.CustomerId,
                UserId = billRequestDto.UserId,
                SaleDate = DateTime.Now,
                TotalAmount = totalAmount,
            };
            var billId = await BillDao.Instance.CreateBill(bill);
            // Check if bill is created
            if (billId <= 0)
            {
                throw new InvalidOperationException("Failed to create the bill.");
            }
            // Add bill items
            foreach (var item in billRequestDto.Jewelries)
            {
                var billJewelry = new BillJewelry
                {
                    BillId = billId,
                    JewelryId = item.JewelryId,
                };
                await BillJewelryDao.Instance.CreateBillJewelry(billJewelry);
            }
            // Add bill promotions
            foreach (var promotion in billRequestDto.Promotions)
            {
                var billPromotion = new BillPromotion
                {
                    BillId = billId,
                    PromotionId = promotion.PromotionId,
                };
                await BillPromotionDao.Instance.CreateBillPromotion(billPromotion);
            }
            // Generate response
            var billResponseDto = new BillResponseDto
            {
                BillId = billId,
                TotalAmount = totalAmount,
                SaleDate = bill.SaleDate,
                Items = billRequestDto.Jewelries.Select(i => new BillItemResponse
                {
                    JewelryId = i.JewelryId,
                    Price = 0 // Calculate price
                }).ToList(),
                Promotions = billRequestDto.Promotions.Select(p => new BillPromotionResponse
                {
                    PromotionId = p.PromotionId,
                    Discount = 0 // Calculate discount
                }).ToList(),
                AdditionalDiscount = billRequestDto.AdditionalDiscount,
                PointsUsed = 0, // Calculate points used
                FinalAmount = 0 // Calculate final amount
            };
            return billResponseDto;
        }
    }
}

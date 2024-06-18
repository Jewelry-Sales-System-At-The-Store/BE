using AutoMapper;
using BusinessObjects.DTO.Bill;
using BusinessObjects.DTO.BillReqRes;
using BusinessObjects.Models;
using Repositories.Implementation;
using Repositories.Interface;
using Repositories.Interface.GenericRepository;
using Services.Interface;
using Tools;

namespace Services.Implementation
{
    public class BillService(
        IMapper mapper,
        IBillRepository billRepository,
        IBillPromotionRepository billPromotionRepository,
        IBillJewelryRepository billJewelryRepository,
        IPromotionRepository promotionRepository,
        IBillDetailRepository billDetailRepository,
        ICustomerRepository customerRepository,
        IUserRepository userRepository,
        IJewelryRepository jewelryRepository) : IBillService
    {
        public IMapper Mapper { get; } = mapper;
        private IBillRepository BillRepository { get; } = billRepository;
        public IBillPromotionRepository BillPromotionRepository { get; } = billPromotionRepository;
        public IBillJewelryRepository BillJewelryRepository { get; } = billJewelryRepository;
        public IPromotionRepository PromotionRepository { get; } = promotionRepository;
        public IBillDetailRepository BillDetailRepository { get; } = billDetailRepository;
        public ICustomerRepository CustomerRepository { get; } = customerRepository;
        public IUserRepository UserRepository { get; } = userRepository;
        public IJewelryRepository JewelryRepository { get; } = jewelryRepository;

        public async Task<BillResponseDto> Create(BillRequestDto billRequestDto)
        {
            double totalAmount = 0;
            double totalDiscountRate = 0;
            double finalAmount = 0;

            // Create bill
            var bill = new Bill
            {
                BillId = IdGenerator.GenerateId(),
                CustomerId = billRequestDto.CustomerId,
                UserId = billRequestDto.UserId,
                SaleDate = DateTime.Now.ToUniversalTime(),
            };

            var billId = await BillRepository.CreateBill(bill);

            // Check if bill is created
            if (billId == null)
            {
                throw new InvalidOperationException("Failed to create the bill.");
            }

            // Add bill items
            foreach (var item in billRequestDto.Jewelries)
            {
                var billJewelry = new BillJewelry
                {
                    BillJewelryId = IdGenerator.GenerateId(),
                    BillId = billId,
                    JewelryId = item.JewelryId,
                };
                await BillJewelryRepository.Create(billJewelry);
            }

            // Add bill promotions
            foreach (var promotion in billRequestDto.Promotions)
            {
                var billPromotion = new BillPromotion
                {
                    BillPromotionId = IdGenerator.GenerateId(),
                    BillId = billId,
                    PromotionId = promotion.PromotionId,
                };
                await BillPromotionRepository.Create(billPromotion);
            }

            // Generate response
            var items = new List<BillItemResponse>();
            foreach (var i in billRequestDto.Jewelries)
            {
                var jewelryPrice = await JewelryRepository.GetById(i.JewelryId);
                var billItemResponse = new BillItemResponse
                {
                    JewelryId = i.JewelryId,
                    Name = jewelryPrice?.Name,
                    LaborCost = jewelryPrice.LaborCost,
                    JewelryPrice = jewelryPrice.JewelryPrice,
                    TotalPrice = jewelryPrice.TotalPrice,
                };
                items.Add(billItemResponse);
            }

            var promotions = new List<BillPromotionResponse>();
            foreach (var p in billRequestDto.Promotions)
            {
                var promotionDiscountRate = await PromotionRepository.GetById(p.PromotionId);
                var billPromotionResponse = new BillPromotionResponse
                {
                    PromotionId = p.PromotionId,
                    Discount = (float)promotionDiscountRate.DiscountRate
                };
                promotions.Add(billPromotionResponse);
            }

            foreach (var totalItemPrice in items)
            {
                totalAmount += totalItemPrice.TotalPrice;
            }

            foreach (var promotion in billRequestDto.Promotions)
            {
                var promotionDiscount = await PromotionRepository.GetById(promotion.PromotionId);
                totalDiscountRate += (double)promotionDiscount.DiscountRate;
            }

            bill.TotalAmount = CalculateFinalAmount(totalAmount, totalDiscountRate);
            await BillRepository.UpdateBill(bill);

            var billResponseDto = new BillResponseDto
            {
                BillId = billId,
                CustomerName = CustomerRepository.GetById(billRequestDto.CustomerId).Result?.Name,
                StaffName = UserRepository.GetById(billRequestDto.UserId).Result?.Username,
                TotalAmount = totalAmount,
                TotalDiscount = totalDiscountRate,
                SaleDate = bill.SaleDate,
                Items = items,
                Promotions = promotions,
                AdditionalDiscount = billRequestDto.AdditionalDiscount,
                PointsUsed = 0, // Calculate points used
                FinalAmount = CalculateFinalAmount(totalAmount, (float)totalDiscountRate)
            };

            await BillDetailRepository.AddBillDetail(Mapper.Map<BillDetailDto>(billResponseDto));
            return billResponseDto;
        }


        public async Task<IEnumerable<BillDetailDto?>?> GetBills()
        {
            return await BillDetailRepository.GetBillDetails();
        }

        public async Task<BillDetailDto?> GetById(string id)
        {
            return await BillDetailRepository.GetBillDetail(id);
        }

        private static double CalculateFinalAmount(double totalAmount, double discountRate)
        {
            return totalAmount - (totalAmount * (discountRate / 100));
        }
    }
}
using BusinessObjects.Dto.BillReqRes;
using BusinessObjects.Dto.BuyBack;
using BusinessObjects.Models;
using Repositories.Interface;
using Services.Interface;
using Tools;

namespace Services.Implementation
{
    public class PurchaseService : IPurchaseService
    {
        private readonly IPurchaseRepository _purchaseRepository;
        private readonly IBillDetailRepository _billDetailRepository;
        private readonly IUserRepository _userRepository;
        private readonly ICustomerRepository _customerRepository;

        public PurchaseService(IPurchaseRepository purchaseRepository, IBillDetailRepository billDetailRepository, IUserRepository userRepository, ICustomerRepository customerRepository)
        {
            _purchaseRepository = purchaseRepository;
            _billDetailRepository = billDetailRepository;
            _userRepository = userRepository;
            _customerRepository = customerRepository;
        }

        public async Task<string> ProcessBuybackById(string jewelryId)
        {
            var purchase = await _purchaseRepository.GetPurchaseByJewelryId(jewelryId);

            if (purchase == null)
            {
                purchase.IsBuyBack = -1;
                return "Jewelry not found or not eligible for buyback.";
            }

            var jewelry = await _purchaseRepository.GetJewelryById(jewelryId);
            if (jewelry == null)
            {
                return "Jewelry not found.";
            }

            var materials = await _purchaseRepository.GetJewelryMaterialByJewelryId(jewelryId);
            jewelry.JewelryMaterials = new List<JewelryMaterial> { materials };

            var totalPrice = CalculateTotalPrice(jewelry.JewelryMaterials, jewelry.LaborCost);

            purchase.IsBuyBack = 1;
            purchase.PurchasePrice = totalPrice;

            var customer = await _customerRepository.GetById(purchase.CustomerId);
            var user = await _userRepository.GetUserById(purchase.UserId);

            var billDetailDto = new BillDetailDto
            {
                Id = Generator.GenerateId(),
                BillId = Generator.GenerateId(), 
                CustomerName = customer?.FullName,
                StaffName = user?.FullName,
                TotalAmount = (double)purchase.PurchasePrice,
                TotalDiscount = 0,
                SaleDate = purchase.PurchaseDate,
                Items = new List<BillItemResponse?>
        {
            new BillItemResponse
            {
                JewelryId = purchase.JewelryId,
                Name = jewelry.Name,
                JewelryPrice = totalPrice,
                TotalPrice = totalPrice
            }
        },
                Promotions = new List<BillPromotionResponse?>(),
                AdditionalDiscount = 0,
                PointsUsed = 0,
                FinalAmount = (double)purchase.PurchasePrice
            };

            await _billDetailRepository.AddBillDetail(billDetailDto);

            purchase.BillId = billDetailDto.BillId;

            await _purchaseRepository.UpdatePurchase(purchase);

            return $"Jewelry updated with purchase price {totalPrice}.";
        }

        public async Task<string> CountProcessBuybackById(string jewelryId)
        {
            var purchase = await _purchaseRepository.GetPurchaseByJewelryId(jewelryId);

            if (purchase == null)
            {
                return "Jewelry not found or not eligible for buyback.";
            }

            var jewelry = await _purchaseRepository.GetJewelryById(jewelryId);
            if (jewelry == null)
            {
                return "Jewelry not found.";
            }

            var materials = await _purchaseRepository.GetJewelryMaterialByJewelryId(jewelryId);
            jewelry.JewelryMaterials = new List<JewelryMaterial> { materials };

            var totalPrice = CalculateTotalPrice(jewelry.JewelryMaterials, jewelry.LaborCost);

            return totalPrice.ToString(); 
        }


        public async Task<string> ProcessBuybackByName(BuybackByNameRequest request)
        {
            var jewelryId = Generator.GenerateId();
            var jewelry = new Jewelry
            {
                JewelryId = jewelryId,
                Name = request.JewelryName,
                JewelryTypeId = request.JewelryTypeId,
                ImageUrl = request.ImageUrl,
                LaborCost = request.LaborCost,
                CreatedAt = DateTimeOffset.UtcNow,
                UpdatedAt = DateTimeOffset.UtcNow
            };

            var jewelryMaterialId = Generator.GenerateId();
            var jewelryMaterial = new JewelryMaterial
            {
                JewelryMaterialId = jewelryMaterialId,
                JewelryId = jewelryId,
                GoldPriceId = request.JewelryMaterial.GoldId,
                StonePriceId = request.JewelryMaterial.StoneId,
                GoldQuantity = request.JewelryMaterial.GoldQuantity,
                StoneQuantity = request.JewelryMaterial.StoneQuantity,
                CreatedAt = DateTimeOffset.UtcNow,
                UpdatedAt = DateTimeOffset.UtcNow
            };

            var customerId = Generator.GenerateId();
            var addCustomer = new Customer
            {
                CustomerId = customerId,
                FullName = request.Customer.FullName,
                Phone = request.Customer.Phone,
                Address = request.Customer.Address,
                CreatedAt = DateTimeOffset.UtcNow, 
                UpdatedAt = DateTimeOffset.UtcNow  
            };

            await _purchaseRepository.CreateJewelry(jewelry);
            await _purchaseRepository.CreateJewelryMaterial(jewelryMaterial);
            await _customerRepository.CreateCustomer(addCustomer); 


            var materials = await _purchaseRepository.GetJewelryMaterialByJewelryId(jewelryId);
            jewelry.JewelryMaterials = new List<JewelryMaterial> { materials };

            var totalPrice = CalculateTotalPrice(new List<JewelryMaterial> { materials }, request.LaborCost);

            var purchase = new Purchase
            {
                PurchaseId = Generator.GenerateId(),
                CustomerId = addCustomer.CustomerId,
                JewelryId = jewelryId,
                UserId = request.UserId,
                PurchaseDate = DateTimeOffset.UtcNow,
                PurchasePrice = request.HasGuarantee ? totalPrice : totalPrice * 0.3,
                IsBuyBack = request.HasGuarantee ? 2 : 3
            };

            var customer = await _customerRepository.GetById(purchase.CustomerId);
            var user = await _userRepository.GetUserById(purchase.UserId);

            var billDetailDto = new BillDetailDto
            {
                Id = Generator.GenerateId(),
                BillId = Generator.GenerateId(), 
                CustomerName = customer?.FullName,
                StaffName = user?.FullName,
                TotalAmount = (double)purchase.PurchasePrice,
                TotalDiscount = 0,
                SaleDate = purchase.PurchaseDate,
                Items = new List<BillItemResponse?>
        {
            new BillItemResponse
            {
                JewelryId = purchase.JewelryId,
                Name = jewelry.Name,
                JewelryPrice = totalPrice,
                TotalPrice = totalPrice
            }
        },
                Promotions = new List<BillPromotionResponse?>(),
                AdditionalDiscount = 0,
                PointsUsed = 0,
                FinalAmount = (double)purchase.PurchasePrice
            };

            await _billDetailRepository.AddBillDetail(billDetailDto);

            purchase.BillId = billDetailDto.BillId;

            await _purchaseRepository.CreatePurchase(purchase);

            return $"Jewelry inserted with buyback {(request.HasGuarantee ? "Graduate"  : "Not Graduate")} and purchase price {purchase.PurchasePrice}";
        }

        public async Task<string> CountProcessBuybackByName(CountBuybackByNameRequest request)
        {
            if (request == null)
            {
                return "Request is null";
            }

            if (request.JewelryMaterial == null)
            {
                return "JewelryMaterial in request is null";
            }

            // Extract necessary details from the request
            var goldPriceId = request.JewelryMaterial.GoldId;
            var stonePriceId = request.JewelryMaterial.StoneId;
            var goldQuantity = request.JewelryMaterial.GoldQuantity;
            var stoneQuantity = request.JewelryMaterial.StoneQuantity;

            // Fetch the gold and stone prices from the database or repository
            var goldPrice = await _purchaseRepository.GetGoldPriceById(goldPriceId);
            var stonePrice = await _purchaseRepository.GetStonePriceById(stonePriceId);

            if (goldPrice == null || stonePrice == null)
            {
                return "Gold price or stone price not found.";
            }

            // Calculate the total price using the updated CalculateTotalPrice method
            var totalPrice = CalculateTotalPriceForName(goldPrice.BuyPrice, goldQuantity, stonePrice.BuyPrice, stoneQuantity, request.LaborCost);

            return totalPrice.ToString(); // Return total price as string
        }




        private static float CalculateTotalPrice(IEnumerable<JewelryMaterial> jewelryMaterials, double? laborCost)
        {
            float totalPrice = 0;
            foreach (var material in jewelryMaterials)
            {
                if (material.GoldPrice != null)
                {
                    totalPrice += material.GoldPrice.BuyPrice * material.GoldQuantity;
                }

                if (material.StonePrice != null)
                {
                    totalPrice += material.StonePrice.BuyPrice * material.StoneQuantity;
                }
            }

            if (laborCost.HasValue)
            {
                totalPrice += (float)laborCost.Value;
            }

            return totalPrice;
        }

        private static float CalculateTotalPriceForName(float goldPrice, float goldQuantity, float stonePrice, float stoneQuantity, double? laborCost)
        {
            float totalPrice = 0;

            totalPrice += goldPrice * goldQuantity;
            totalPrice += stonePrice * stoneQuantity;

            if (laborCost.HasValue)
            {
                totalPrice += (float)laborCost.Value;
            }

            return totalPrice;
        }
    }
}

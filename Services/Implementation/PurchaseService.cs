using BusinessObjects.Dto.BuyBack;
using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace Repositories.Implementation
{
    public class PurchaseService : IPurchaseService
    {
        private readonly IPurchaseRepository _purchaseRepository;

        public PurchaseService(IPurchaseRepository purchaseRepository)
        {
            _purchaseRepository = purchaseRepository;
        }

        public async Task<string> ProcessBuybackById(string jewelryId)
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

            purchase.IsBuyBack = 1;
            purchase.PurchasePrice = totalPrice;
            await _purchaseRepository.UpdatePurchase(purchase);

            return $"Jewelry updated with purchase price {totalPrice}.";
        }

        public async Task<string> ProcessBuybackByName(BuybackByNameRequest request)
        {
            // Generate IDs for new entities
            var jewelryId = Generator.GenerateId();
            var jewelryMaterialId = Generator.GenerateId();
            var customerId = Generator.GenerateId();

            // Create new Jewelry entity
            var jewelry = new Jewelry
            {
                JewelryId = jewelryId,
                Name = request.JewelryName,
                JewelryTypeId = request.JewelryTypeId,
                ImageUrl = request.ImageUrl,
                LaborCost = request.LaborCost,
                CreatedAt = DateTimeOffset.UtcNow, // Convert to UTC
                UpdatedAt = DateTimeOffset.UtcNow  // Convert to UTC
            };

            // Create new JewelryMaterial entity
            var jewelryMaterial = new JewelryMaterial
            {
                JewelryMaterialId = jewelryMaterialId,
                JewelryId = jewelryId,
                GoldPriceId = request.JewelryMaterial.GoldId,
                StonePriceId = request.JewelryMaterial.StoneId,
                GoldQuantity = request.JewelryMaterial.GoldQuantity,
                StoneQuantity = request.JewelryMaterial.StoneQuantity,
                CreatedAt = DateTimeOffset.UtcNow, // Convert to UTC
                UpdatedAt = DateTimeOffset.UtcNow  // Convert to UTC
            };

            // Create new Customer entity
            var customer = new Customer
            {
                CustomerId = customerId,
                FullName = request.Customer.FullName,
                Phone = request.Customer.Phone,
                Address = request.Customer.Address,
                CreatedAt = DateTimeOffset.UtcNow, // Convert to UTC
                UpdatedAt = DateTimeOffset.UtcNow  // Convert to UTC
            };

            // Save entities using the repository
            await _purchaseRepository.CreateJewelry(jewelry);
            await _purchaseRepository.CreateJewelryMaterial(jewelryMaterial);
            await _purchaseRepository.CreateCustomer(customer); // This line is added to save the customer


            var materials = await _purchaseRepository.GetJewelryMaterialByJewelryId(jewelryId);
            jewelry.JewelryMaterials = new List<JewelryMaterial> { materials };

            // Calculate total price
            var totalPrice = CalculateTotalPrice(new List<JewelryMaterial> { materials }, request.LaborCost);
           

            // Create new Purchase entity
            var purchase = new Purchase
            {
                PurchaseId = Generator.GenerateId(),
                JewelryId = jewelryId,
                UserId = request.UserId,
                CustomerId = customerId,
                PurchaseDate = DateTimeOffset.UtcNow, // Convert to UTC
                PurchasePrice = request.HasGuarantee ? totalPrice : totalPrice * 0.3,
                IsBuyBack = request.HasGuarantee ? 2 : 3
            };
            // Save the purchase
            await _purchaseRepository.CreatePurchase(purchase);

            return $"Jewelry inserted with buyback {(request.HasGuarantee ? "HasGuarantee" : "NoGuarantee")} and purchase price {purchase.PurchasePrice}";
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
    }
}

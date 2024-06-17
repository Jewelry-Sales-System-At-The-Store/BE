using AutoMapper;
using BusinessObjects.Models;
using DAO;
using Repositories.Interface;

namespace Repositories.Implementation
{
    public class JewelryRepository(
        JewelryDao jewelryDao,
        JewelryTypeDao jewelryTypeDao,
        GoldPriceDao goldPriceDao,
        GemPriceDao gemPriceDao,
        JewelryMaterialDao jewelryMaterialDao) : IJewelryRepository
    {
        public JewelryDao JewelryDao { get; } = jewelryDao;
        public JewelryTypeDao JewelryTypeDao { get; } = jewelryTypeDao;
        public GoldPriceDao GoldPriceDao { get; } = goldPriceDao;
        public GemPriceDao GemPriceDao { get; } = gemPriceDao;
        public JewelryMaterialDao JewelryMaterialDao { get; } = jewelryMaterialDao;

        public async Task<int> Create(Jewelry entity)
        {
            entity.IsSold = false;
            return await JewelryDao.CreateJewelry(entity);
        }

        public async Task<int> Delete(string id)
        {
            return await JewelryDao.DeleteJewelry(id);
        }

        public async Task<IEnumerable<(Jewelry? Jewelry, float TotalPrice)>?> Gets()
        {
            var jewelries = await JewelryDao.GetJewelries();
            var jewelryList = new List<(Jewelry?, float)>();

            foreach (var jewelry in jewelries)
            {
                var jewelryType = await JewelryTypeDao.GetJewelryTypeById(jewelry.JewelryTypeId);
                var jewelryMaterial = await JewelryMaterialDao.GetJewelryMaterialByJewelry(jewelry.JewelryId);
                var goldType = await GoldPriceDao.GetGoldPriceById(jewelryMaterial.GoldPriceId);
                var stoneType = await GemPriceDao.GetStonePriceById(jewelryMaterial.StonePriceId);

                jewelryMaterial.GoldPrice = goldType;
                jewelryMaterial.StonePrice = stoneType;
                jewelry.JewelryType = jewelryType;
                jewelry.JewelryMaterials = new List<JewelryMaterial> { jewelryMaterial };

                var totalPrice = CalculateTotalPrice(jewelryMaterial, jewelry.LaborCost);
                
                jewelryList.Add((jewelry, totalPrice));
            }

            return jewelryList;
        }

        public async Task<(Jewelry? Jewelry, float TotalPrice)> GetById(string id)
        {
            var jewelry = await JewelryDao.GetJewelryById(id);
            var jewelryType = await JewelryTypeDao.GetJewelryTypeById(jewelry.JewelryTypeId);
            var jewelryMaterial = await JewelryMaterialDao.GetJewelryMaterialByJewelry(id);
            var goldType = await GoldPriceDao.GetGoldPriceById(jewelryMaterial.GoldPriceId);
            var stoneType = await GemPriceDao.GetStonePriceById(jewelryMaterial.StonePriceId);

            jewelryMaterial.GoldPrice = goldType;
            jewelryMaterial.StonePrice = stoneType;
            jewelry.JewelryType = jewelryType;
            jewelry.JewelryMaterials = new List<JewelryMaterial> { jewelryMaterial };

            var totalPrice = CalculateTotalPrice(jewelryMaterial, jewelry.LaborCost);
            
            return (jewelry, totalPrice);        }


        public async Task<int> Update(string id, Jewelry entity)
        {
            return await JewelryDao.UpdateJewelry(id, entity);
        }
        private static float CalculateTotalPrice(JewelryMaterial jewelryMaterial, double? laborCost)
        {
            float totalPrice = 0;
            if (jewelryMaterial.GoldPrice != null)
            {
                totalPrice += jewelryMaterial.GoldPrice.BuyPrice * jewelryMaterial.GoldQuantity;
            }
            if (jewelryMaterial.StonePrice != null)
            {
                totalPrice += jewelryMaterial.StonePrice.BuyPrice * jewelryMaterial.StoneQuantity;
            }
            totalPrice += (float)laborCost;
            return totalPrice;
        }
    }
}
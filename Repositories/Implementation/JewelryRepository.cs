using BusinessObjects.DTO.ResponseDto;
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
        private JewelryDao JewelryDao { get; } = jewelryDao;
        private JewelryTypeDao JewelryTypeDao { get; } = jewelryTypeDao;
        private GoldPriceDao GoldPriceDao { get; } = goldPriceDao;
        private GemPriceDao GemPriceDao { get; } = gemPriceDao;
        private JewelryMaterialDao JewelryMaterialDao { get; } = jewelryMaterialDao;

        public async Task<int> Create(Jewelry entity)
        {
            entity.IsSold = false;
            return await JewelryDao.CreateJewelry(entity);
        }

        public async Task<int> Delete(string id)
        {
            return await JewelryDao.DeleteJewelry(id);
        }

        public async Task<(int, int, IEnumerable<JewelryResponseDto>)> GetsJewelryPaging(int pageNumber, int pageSize)
        {
            var jewelries = await JewelryDao.GetJewelries(pageNumber, pageSize);
            if (jewelries.Item3 == null || !jewelries.Item3.Any())
            {
                return default;
            }

            var jewelryResponseDtos = new List<JewelryResponseDto>();

            foreach (var jewelry in jewelries.Item3)
            {
                var jewelryType = await JewelryTypeDao.GetJewelryTypeById(jewelry.JewelryTypeId);
                var jewelryMaterials = await JewelryMaterialDao.GetJewelryMaterialByJewelry(jewelry.JewelryId);
                var jewelryMaterialList = new List<JewelryMaterial> { jewelryMaterials };
                foreach (var jewelryMaterial in jewelryMaterialList)
                {
                    var goldType = await GoldPriceDao.GetGoldPriceById(jewelryMaterial.GoldPriceId);
                    var stoneType = await GemPriceDao.GetStonePriceById(jewelryMaterial.StonePriceId);

                    jewelryMaterial.GoldPrice = goldType;
                    jewelryMaterial.StonePrice = stoneType;
                }

                jewelry.JewelryType = jewelryType;
                jewelry.JewelryMaterials = jewelryMaterialList;

                var totalPrice = jewelry.JewelryMaterials.Sum(jm => CalculateTotalPrice(jm, jewelry.LaborCost));

                var jewelryResponseDto = new JewelryResponseDto
                {
                    JewelryId = jewelry.JewelryId,
                    Name = jewelry.Name,
                    Type = jewelryType.Name,
                    Barcode = jewelry.Barcode,
                    LaborCost = jewelry.LaborCost,
                    Materials = jewelry.JewelryMaterials.Select(jm => new Materials
                    {
                        Gold = new GoldResponseDto
                        {
                            GoldType = jm.GoldPrice?.Type,
                            GoldQuantity = jm.GoldQuantity,
                            GoldPrice = jm.GoldPrice?.SellPrice ?? 0
                        },
                        Gem = new GemResponseDto
                        {
                            Gem = jm.StonePrice?.Type,
                            GemQuantity = jm.StoneQuantity,
                            GemPrice = jm.StonePrice?.SellPrice ?? 0
                        }
                    }).ToList(),
                    TotalPrice = totalPrice
                };

                jewelryResponseDtos.Add(jewelryResponseDto);
            }

            return (jewelries.Item1, jewelries.Item2, jewelryResponseDtos);
        }

        public Task<IEnumerable<JewelryResponseDto>?> Gets()
        {
            throw new NotImplementedException();
        }

        public async Task<JewelryResponseDto> GetById(string id)
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

            var jewelryResponseDto = new JewelryResponseDto
            {
                JewelryId = jewelry.JewelryId,
                Name = jewelry.Name,
                Type = jewelryType.Name,
                Barcode = jewelry.Barcode,
                JewelryPrice = CalculateJewelryPrice(jewelryMaterial),
                LaborCost = jewelry.LaborCost,
                Materials = jewelry.JewelryMaterials.Select(jm => new Materials
                {
                    Gold = new GoldResponseDto
                    {
                        GoldType = jm.GoldPrice?.Type,
                        GoldQuantity = jm.GoldQuantity,
                        GoldPrice = jm.GoldPrice?.SellPrice ?? 0
                    },
                    Gem = new GemResponseDto
                    {
                        Gem = jm.StonePrice?.Type,
                        GemQuantity = jm.StoneQuantity,
                        GemPrice = jm.StonePrice?.SellPrice ?? 0
                    }
                }).ToList(),
                TotalPrice = totalPrice
            };

            return jewelryResponseDto;
        }

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

        private static float CalculateJewelryPrice(JewelryMaterial jewelryMaterial)
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

            return totalPrice;
        }
    }
}
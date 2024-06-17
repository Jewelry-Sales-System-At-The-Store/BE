using BusinessObjects.DTO.ResponseDto;
using BusinessObjects.Models;
using Repositories.Interface;
using Services.Interface;

namespace Services.Implementation
{
    public class JewelryService(IJewelryRepository jewelryRepository) : IJewelryService
    {
        public IJewelryRepository JewelryRepository { get; } = jewelryRepository;

        public async Task<IEnumerable<JewelryResponseDto?>?> GetJewelries()
        {
            var jewelries = await JewelryRepository.Gets();
            var jewelryResponseDto = jewelries?.Select(jewelry => new JewelryResponseDto
            {
                JewelryId = jewelry.Jewelry?.JewelryId,
                Name = jewelry.Jewelry?.Name,
                Type = jewelry.Jewelry?.JewelryType?.Name,
                Barcode = jewelry.Jewelry?.Barcode,
                LaborCost = jewelry.Jewelry?.LaborCost,
                Materials = jewelry.Jewelry?.JewelryMaterials.Select(jm => new Materials
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
                TotalPrice = jewelry.TotalPrice
            }).ToList();

            return jewelryResponseDto ?? [];
        }

        public async Task<JewelryResponseDto?> GetJewelryById(string id)
        {
            var jewelry = await JewelryRepository.GetById(id);
            var jewelryResponseDto = new JewelryResponseDto
            {
                JewelryId = jewelry.Jewelry?.JewelryId,
                Name = jewelry.Jewelry?.Name,
                Type = jewelry.Jewelry?.JewelryType?.Name,
                Barcode = jewelry.Jewelry?.Barcode,
                LaborCost = jewelry.Jewelry?.LaborCost,
                Materials = jewelry.Jewelry?.JewelryMaterials.Select(jm => new Materials
                {
                    Gold = new GoldResponseDto
                    {
                        GoldType = jm.GoldPrice?.Type,
                        GoldQuantity = jm.GoldQuantity,
                        GoldPrice = jm.GoldPrice?.SellPrice
                    },
                    Gem = new GemResponseDto
                    {
                        Gem = jm.StonePrice?.Type,
                        GemQuantity = jm.StoneQuantity,
                        GemPrice = jm.StonePrice?.SellPrice
                    }
                }).ToList(),
                TotalPrice = jewelry.TotalPrice
            };
            return jewelryResponseDto;
        }


        public async Task<int> CreateJewelry(Jewelry jewelry)
        {
            return await JewelryRepository.Create(jewelry);
        }

        public Task<int> DeleteJewelry(string id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<int> UpdateJewelry(string id, Jewelry jewelry)
        {
            return await JewelryRepository.Update(id, jewelry);
        }

    }
}

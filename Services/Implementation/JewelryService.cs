using BusinessObjects.DTO.Jewelry;
using BusinessObjects.DTO.ResponseDto;
using BusinessObjects.Models;
using Repositories.Implementation;
using Repositories.Interface;
using Services.Interface;
using Tools;

namespace Services.Implementation
{
    public class JewelryService(
        IJewelryRepository jewelryRepository,
        IJewelryMaterialRepository jewelryMaterialRepository) : IJewelryService
    {
        private IJewelryRepository JewelryRepository { get; } = jewelryRepository;
        public IJewelryMaterialRepository JewelryMaterialRepository { get; } = jewelryMaterialRepository;

        public async Task<IEnumerable<JewelryResponseDto?>?> GetJewelries()
        {
            var jewelries = await JewelryRepository.Gets();
            return jewelries;
        }

        public async Task<JewelryResponseDto?> GetJewelryById(string id)
        {
            var jewelryResponseDto = await JewelryRepository.GetById(id);
            return jewelryResponseDto;
        }


        public async Task<int> CreateJewelry(JewelryRequestDto jewelryRequestDto)
        {
            // Create Jewelry first before creating JewelryMaterial
            var jewelry = new Jewelry
            {
                JewelryId = IdGenerator.GenerateId(),
                JewelryTypeId = jewelryRequestDto.JewelryTypeId,
                Name = jewelryRequestDto.Name,
                Barcode = jewelryRequestDto.Barcode,
                LaborCost = jewelryRequestDto.LaborCost,
                IsSold = false
            };
            try
            {
                await JewelryRepository.Create(jewelry);
            }
            catch (Exception e)
            {
                throw new CustomException.InvalidDataException("Failed to create Jewelry.");
            }
            // Create JewelryMaterial
            var jewelryMaterial = new JewelryMaterial
            {
                JewelryMaterialId = IdGenerator.GenerateId(),
                JewelryId = jewelry.JewelryId,
                GoldPriceId = jewelryRequestDto.JewelryMaterial.GoldId,
                StonePriceId = jewelryRequestDto.JewelryMaterial.GemId,
                GoldQuantity = jewelryRequestDto.JewelryMaterial.GoldQuantity,
                StoneQuantity = jewelryRequestDto.JewelryMaterial.GemQuantity
            };
            try
            {
                await JewelryMaterialRepository.Create(jewelryMaterial);
                return 1;
            }
            catch (Exception e)
            {
                await JewelryRepository.Delete(jewelry.JewelryId);
                throw new CustomException.InvalidDataException("Failed to create JewelryMaterial.");
            }
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
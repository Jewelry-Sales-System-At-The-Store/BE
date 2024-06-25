using BusinessObjects.DTO.Jewelry;
using BusinessObjects.DTO.Other;
using BusinessObjects.DTO.ResponseDto;
using BusinessObjects.Models;

namespace Services.Interface
{
    public interface IJewelryService
    {
        public Task<PagingResponse> GetJewelries(int pageNumber, int pageSize);
        public Task<JewelryResponseDto?> GetJewelryById(string id);
        public Task<PagingResponse?> GetJewelryByType(string jewelryTypeId, int pageNumBer, int pageSize);
        public Task<int> CreateJewelry(JewelryRequestDto jewelryRequestDto);
        public Task<int> UpdateJewelry(string id, Jewelry jewelry);
        public Task<int> DeleteJewelry(string id);
    }
}

using BusinessObjects.DTO.ResponseDto;
using BusinessObjects.Models;

namespace Services.Interface;

public interface IGoldPriceService
{
    Task<IEnumerable<GoldPriceResponseDto>?> GetGoldPrices();
}
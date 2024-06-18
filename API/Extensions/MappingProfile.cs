using AutoMapper;
using BusinessObjects.DTO;
using BusinessObjects.DTO.Bill;
using BusinessObjects.DTO.BillReqRes;
using BusinessObjects.DTO.Jewelry;
using BusinessObjects.DTO.ResponseDto;
using BusinessObjects.Models;

namespace API.Extensions
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Jewelry, JewelryRequestDto>().ReverseMap();
            CreateMap<Warranty, WarrantyDto>().ReverseMap();
            CreateMap<JewelryType, JewelryTypeDto>().ReverseMap();
            CreateMap<Promotion, PromotionDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Role, RoleDto>().ReverseMap();
            // ResponseDto Mapping
            CreateMap<Gold, GoldPriceResponseDto>().ReverseMap();
            CreateMap<Gem, GemPriceResponseDto>().ReverseMap();
            //MongoMap
            CreateMap<BillResponseDto, BillDetailDto>().ReverseMap();
        }
    }
}

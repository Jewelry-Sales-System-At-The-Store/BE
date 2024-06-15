using AutoMapper;
using BusinessObjects.DTO;
using BusinessObjects.DTO.ResponseDto;
using BusinessObjects.Models;

namespace API.Extensions
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Jewelry, JewelryDto>().ReverseMap();
            CreateMap<Warranty, WarrantyDto>().ReverseMap();
            CreateMap<JewelryType, JewelryTypeDto>().ReverseMap();
            CreateMap<Promotion, PromotionDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Role, RoleDto>().ReverseMap();
            // ResponseDto Mapping
            CreateMap<GoldPrice, GoldPriceResponseDto>().ReverseMap();
        }
    }
}

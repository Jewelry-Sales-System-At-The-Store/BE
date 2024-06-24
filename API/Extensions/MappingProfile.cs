using AutoMapper;
using BusinessObjects.DTO;
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
            // RequestDto Mapping
            CreateMap<Jewelry, JewelryRequestDto>().ReverseMap();
            // Dto Mapping
            CreateMap<Warranty, WarrantyDto>().ReverseMap();
            CreateMap<JewelryType, JewelryTypeDto>().ReverseMap();
            CreateMap<Promotion, PromotionDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Role, RoleDto>().ReverseMap();
            CreateMap<Customer, CustomerDto>().ReverseMap();
            // ResponseDto Mapping
            CreateMap<Gold, GoldPriceResponseDto>().ReverseMap();
            CreateMap<Gem, GemPriceResponseDto>().ReverseMap();
            CreateMap<Customer, CustomerResponseDto>();
            CreateMap<User, UserResponseDto>();
            // MongoDB Mapping
            CreateMap<BillResponseDto, BillDetailDto>().ReverseMap();
            // Paging Mapping
        }
    }
}

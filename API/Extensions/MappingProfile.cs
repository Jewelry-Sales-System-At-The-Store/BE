using AutoMapper;
using BusinessObjects.Dto;
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
        }
    }
}

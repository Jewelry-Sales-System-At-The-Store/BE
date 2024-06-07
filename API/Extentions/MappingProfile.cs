using AutoMapper;
using BusinessObjects.DTO;
using BusinessObjects.Models;

namespace API.Extentions
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Jewelry, JewelryDto>().ReverseMap();
            CreateMap<Warranty, WarrantyDto>().ReverseMap();
            CreateMap<JewelryType, JewelryTypeDto>().ReverseMap();
            CreateMap<Promotion, PromotionDto>().ReverseMap();
            CreateMap<Bill, BillDto>().ReverseMap();
        }
    }
}

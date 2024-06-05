using AutoMapper;
using BusinessObjects.DTO;
using BusinessObjects.Models;

namespace API.Extentions
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Jewelry, JewelryDTO>().ReverseMap();
            CreateMap<Warranty, WarrantyDTO>().ReverseMap();
            CreateMap<Bill, BillResponseDTO>()
            .ForMember(destination => destination.CustomerName, opt => opt.MapFrom(src => src.Customer.Name))
            .ForMember(destination => destination.Jewelries, opt => opt.MapFrom(src => src.BillJewelries.Select(bj => bj.Jewelry)));
            CreateMap<JewelryType, JewelryTypeDTO>().ReverseMap();
        }
    }
}

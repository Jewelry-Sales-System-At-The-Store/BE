using AutoMapper;
using BusinessObjects.DTO;
using BusinessObjects.Models;

namespace API.Extensions
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Jewelry, JewelryDTO>().ReverseMap();
            CreateMap<Warranty, WarrantyResponseDTO>()
            .ForMember(dest => dest.Jewelries, opt => opt.MapFrom(src => src.Jewelries));
            CreateMap<Bill, BillResponseDTO>()
            .ForMember(destination => destination.CustomerName, opt => opt.MapFrom(src => src.Customer.Name))
            .ForMember(destination => destination.Jewelries, opt => opt.MapFrom(src => src.BillJewelries.Select(bj => bj.Jewelry)));

            CreateMap<Jewelry, JewelryResponseDTO>()
            .ForMember(dest => dest.Warranty, opt => opt.Ignore())  // Tránh vòng lặp
            .ForMember(dest => dest.JewelryType, opt => opt.MapFrom(src => src.JewelryType));
            CreateMap<Warranty, WarrantyResponseDTO>();
            CreateMap<JewelryType, JewelryTypeResponseDTO>();
        }
    }
}

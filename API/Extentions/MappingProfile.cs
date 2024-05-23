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
            CreateMap<Bill, BillResponseDTO>().ReverseMap();
        }
    }
}

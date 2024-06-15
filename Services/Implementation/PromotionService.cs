using BusinessObjects.Models;
using Repositories.Interface;
using Services.Interface;
using AutoMapper;
using BusinessObjects.DTO;

namespace Services.Implementation
{
    public class PromotionService(IPromotionRepository promotionRepository, IMapper mapper) : IPromotionService
    {
        public IPromotionRepository PromotionRepository { get; } = promotionRepository;
        public IMapper Mapper { get; } = mapper;

        public async Task<int> CreatePromotion(PromotionDto promotionDto)
        {
            return await PromotionRepository.Create(Mapper.Map<Promotion>(promotionDto));
        }

        public async Task<int> DeletePromotion(string id)
        {
            return await PromotionRepository.Delete(id);
        }

        public async Task<IEnumerable<Promotion?>?> GetPromotions()
        {
            return await PromotionRepository.Gets();
        }

        public Task<Promotion?> GetPromotionById(string id)
        {
            return PromotionRepository.GetById(id);
        }

        public async Task<int> UpdatePromotion(string id, PromotionDto promotionDto)
        {
            return await PromotionRepository.Update(id, Mapper.Map<Promotion>(promotionDto));
        }
    }
}

using BusinessObjects.DTO;
using BusinessObjects.Models;
using Repositories.Interface;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementation
{
    public class PromotionService(IPromotionRepository promotionRepository) : IPromotionService
    {
        public IPromotionRepository PromotionRepository { get; } = promotionRepository;
        public async Task<int> CreatePromotion(PromotionDTO promotion)
        {
            return await PromotionRepository.Create(promotion);
        }

        public async Task<int> DeletePromotion(int id)
        {
            return await PromotionRepository.Delete(id);
        }

        public async Task<IEnumerable<Promotion?>?> GetPromotions()
        {
            return await PromotionRepository.GetAll();
        }

        public async Task<int> UpdatePromotion(int id, PromotionDTO promotion)
        {
            return await PromotionRepository.Update(id, promotion);
        }
    }
}

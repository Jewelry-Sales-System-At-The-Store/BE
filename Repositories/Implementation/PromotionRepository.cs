using Azure.Core;
using BusinessObjects.DTO;
using BusinessObjects.Models;
using DAO;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Implementation
{
    public class PromotionRepository : IPromotionRepository
    {
        public async Task<int> Create(PromotionDTO promotionDTO)
        {
            var newPromotion = new Promotion
            {
                Type = promotionDTO.Type,
                ApproveManager = promotionDTO.ApproveManager,
                Description = promotionDTO.Description,
                DiscountRate = promotionDTO.DiscountRate,
                StartDate = promotionDTO.StartDate,
                EndDate = promotionDTO.EndDate
            };
            var result = await PromotionDAO.Instance.CreatePromotion(newPromotion);
            return result;
        }

        public async Task<int> Delete(int id)
        {
            return await PromotionDAO.Instance.DeletePromotion(id);
        }

        public async Task<IEnumerable<Promotion?>?> GetAll()
        {
            return await PromotionDAO.Instance.GetPromotions();
        }

        public Task<Promotion?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(int id, PromotionDTO entity)
        {
            return await PromotionDAO.Instance.UpdatePromotion(id, entity);
        }
    }
}

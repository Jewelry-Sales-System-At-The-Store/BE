using BusinessObjects.Models;
using DAO;
using Repositories.Interface;

namespace Repositories.Implementation
{
    public class PromotionRepository : IPromotionRepository
    {
        public async Task<int> Create(Promotion promotion)
        {
            var result = await PromotionDao.Instance.CreatePromotion(promotion);
            return result;
        }

        public async Task<int> Delete(string id)
        {
            return await PromotionDao.Instance.DeletePromotion(id);
        }

        public async Task<IEnumerable<Promotion?>?> Gets()
        {
            return await PromotionDao.Instance.GetPromotions();
        }

        public Task<Promotion?> GetById(string id)
        {
            return PromotionDao.Instance.GetPromotionById(id);
        }

        public async Task<int> Update(string id, Promotion promotion)
        {
            return await PromotionDao.Instance.UpdatePromotion(id, promotion);
        }
    }
}

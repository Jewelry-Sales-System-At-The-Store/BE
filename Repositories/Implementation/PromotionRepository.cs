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

        public async Task<int> Delete(int id)
        {
            return await PromotionDao.Instance.DeletePromotion(id);
        }

        public async Task<IEnumerable<Promotion?>?> GetAll()
        {
            return await PromotionDao.Instance.GetPromotions();
        }

        public Task<Promotion?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(int id, Promotion promotion)
        {
            return await PromotionDao.Instance.UpdatePromotion(id, promotion);
        }
    }
}

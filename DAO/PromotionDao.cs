using BusinessObjects.Context;
using BusinessObjects.DTO;
using BusinessObjects.Models;
using DAO.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public class PromotionDao : Singleton<PromotionDao>
    {
        private readonly JssatsContext _context;

        public PromotionDao()
        {
            _context = new JssatsContext();
        }

        public async Task<IEnumerable<Promotion>> GetPromotions()
        {
            return await _context.Promotions.ToListAsync();
        }

        public async Task<int> CreatePromotion(Promotion promotion)
        {
            await _context.Promotions.AddAsync(promotion);
            return await _context.SaveChangesAsync();
        }
        
        public async Task<int> UpdatePromotion(int id, Promotion promotion)
        {
            throw new NotImplementedException();
        }

        public async Task<int> DeletePromotion(int id)
        {
            var existPromotion = await _context.Promotions.FirstOrDefaultAsync(x => x.PromotionId == id);
            if (existPromotion == null) return 0;
            _context.Remove(existPromotion);
            return await _context.SaveChangesAsync();
        }
    }
}
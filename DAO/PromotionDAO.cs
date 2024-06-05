using BusinessObjects.Context;
using BusinessObjects.DTO;
using BusinessObjects.Models;
using DAO.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public class PromotionDAO : Singleton<PromotionDAO>
    {
        private readonly JssatsContext _context;

        public PromotionDAO()
        {
            _context = new JssatsContext();
        }

        public async Task<IEnumerable<Promotion>> GetPromotions()
        {
            return await _context.Promotions.ToListAsync();
        }

        public async Task<int> CreatePromotion(Promotion promotion)
        {
            var maxPromotionId = await _context.Promotions.MaxAsync(x => (int?)x.PromotionId) ?? 0;
            promotion.PromotionId = maxPromotionId + 1;

            var existUser = await _context.Users
                .Include(u => u.Role)
                .FirstOrDefaultAsync(x => x.Username == promotion.ApproveManager) ?? throw new ArgumentException("User does not exist");
            if (existUser.Role?.RoleName != "Manager")
            {
                throw new ArgumentException("User does not have the Manager role");
            }
            promotion.ApproveManager = existUser.Username;
            _context.Promotions.Add(promotion);

            return await _context.SaveChangesAsync();
        }


        public async Task<int> UpdatePromotion(int id, PromotionDTO promotion)
        {
            var existPromotion = await _context.Promotions.FirstOrDefaultAsync(x => x.PromotionId == id);
            if (existPromotion == null) return 0;

            var existUser = await _context.Users
                .Include(u => u.Role)
                .FirstOrDefaultAsync(x => x.Username == promotion.ApproveManager);

            if (existUser == null)
            {
                throw new ArgumentException("User does not exist");
            }

            if (existUser.Role?.RoleName != "Manager")
            {
                throw new ArgumentException("User does not have the Manager role");
            }
            promotion.ApproveManager = existUser.Username;

            _context.Entry(existPromotion).CurrentValues.SetValues(promotion);
            _context.Entry(existPromotion).State = EntityState.Modified;
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeletePromotion(int id)
        {
            var existPromotion = await _context.Promotions.FirstOrDefaultAsync(x=>x.PromotionId == id);
            if (existPromotion == null) return 0;
            _context.Remove(existPromotion);
            return await _context.SaveChangesAsync();
        }
    }
}

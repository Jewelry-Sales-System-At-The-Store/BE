using BusinessObjects.Models;
using DAO.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PromotionDAO
    {
        private readonly JssatsV2Context _context;
        public static PromotionDAO? _instance;

        public PromotionDAO()
        {
            _context = new JssatsV2Context();
        }

        public static PromotionDAO Instance
        {
            get
            {
                _instance ??= new PromotionDAO();
                return _instance;
            }
        }

        public async Task<IEnumerable<Promotion>> GetPromotions()
        {
            return await _context.Promotions.ToListAsync();
        }

        public async Task<int> CreatePromotion(Promotion promotion)
        {
            var existPromotion = await _context.Promotions.MaxAsync(x => x.PromotionId);
            promotion.PromotionId = existPromotion + 1;
            _context.Promotions.Add(promotion);
            return await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdatePromotion(int id, Promotion promotion)
        {
            var existPromotion = await _context.Promotions.FirstOrDefaultAsync(x => x.PromotionId == id);
            if (existPromotion == null) return false;
            _context.Entry(existPromotion).CurrentValues.SetValues(promotion);
            _context.Entry(existPromotion).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeletePromotion(int id)
        {
            var existPromotion = await _context.Promotions.FirstOrDefaultAsync(x=>x.PromotionId == id);
            if (existPromotion == null) return false;
            _context.Remove(existPromotion);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

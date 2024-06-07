using BusinessObjects.DTO;
using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IPromotionService
    {
        public Task<int> CreatePromotion(PromotionDto promotion);
        public Task<IEnumerable<Promotion?>?> GetPromotions();
        public Task<int> UpdatePromotion(int id, PromotionDto promotion);
        public Task<int> DeletePromotion(int id);
    }
}

using BusinessObjects.DTO;
using BusinessObjects.Models;
using Repositories.Interface.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
    public interface IPromotionRepository : IReadRepository<Promotion>, ICreateRepository<PromotionDTO>, IUpdateRepository<PromotionDTO>, IDeleteRepository<Promotion>
    {
    }
}

using BusinessObjects.DTO;
using BusinessObjects.Models;
using Repositories.Interface.GenericRepository;

namespace Repositories.Interface;

public interface IPromotionRepository : IReadRepository<Promotion>, ICreateRepository<PromotionDTO>, IUpdateRepository<PromotionDTO>, IDeleteRepository<Promotion>
{
}

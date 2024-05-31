using BusinessObjects.DTO;
using BusinessObjects.Models;
using Repositories.Interface.GenericRepository;
namespace Repositories.Interface;

public interface IJewelryRepository : IReadRepository<JewelryResponseDTO>, ICreateRepository<Jewelry>, IUpdateRepository<Jewelry>, IDeleteRepository<Jewelry>
{
}

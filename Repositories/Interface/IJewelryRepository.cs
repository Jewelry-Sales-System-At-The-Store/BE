using BusinessObjects.DTO;
using BusinessObjects.Models;
using Repositories.Interface.GenericRepository;
namespace Repositories.Interface;

public interface IJewelryRepository : IReadRepository<Jewelry>, ICreateRepository<Jewelry>, IUpdateRepository<Jewelry>, IDeleteRepository<Jewelry>
{
}

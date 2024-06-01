using BusinessObjects.DTO;
using BusinessObjects.Models;
using Repositories.Interface.GenericRepository;
namespace Repositories.Interface;

public interface IWarrantyRepository : IReadRepository<WarrantyResponseDTO>, ICreateRepository<Warranty>, IUpdateRepository<Warranty>
{

}

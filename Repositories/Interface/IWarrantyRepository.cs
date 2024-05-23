using BusinessObjects.Models;
namespace Repositories.Interface
{
    public interface IWarrantyRepository : IReadRepository<Warranty>, ICreateRepository<Warranty>, IUpdateRepository<Warranty>
    {

    }
}

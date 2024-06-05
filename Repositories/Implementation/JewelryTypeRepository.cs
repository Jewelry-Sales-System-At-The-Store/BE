using BusinessObjects.Models;
using DAO;
using Repositories.Interface;

namespace Repositories.Implementation;

public class JewelryTypeRepository : IJewelryTypeRepository
{
    public async Task<IEnumerable<JewelryType?>?> GetAll()
    {
        return await JewelryTypeDAO.Instance.GetJewelryTypes();
    }

    public async Task<JewelryType?> GetById(int id)
    {
        return await JewelryTypeDAO.Instance.GetJewelryTypeById(id);
    }

    public async Task<int> Create(JewelryType entity)
    {
        return await JewelryTypeDAO.Instance.CreateJewelryType(entity);
    }

    public async Task<int> Update(int id, JewelryType entity)
    {
        return await JewelryTypeDAO.Instance.UpdateJewelryType(id, entity);
    }
}
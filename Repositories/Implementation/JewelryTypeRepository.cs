using BusinessObjects.Models;
using DAO;
using Repositories.Interface;

namespace Repositories.Implementation;

public class JewelryTypeRepository : IJewelryTypeRepository
{
    public async Task<IEnumerable<JewelryType?>?> GetAll()
    {
        return await JewelryTypeDao.Instance.GetJewelryTypes();
    }

    public async Task<JewelryType?> GetById(int id)
    {
        return await JewelryTypeDao.Instance.GetJewelryTypeById(id);
    }

    public async Task<int> Create(JewelryType entity)
    {
        return await JewelryTypeDao.Instance.CreateJewelryType(entity);
    }

    public async Task<int> Update(int id, JewelryType entity)
    {
        return await JewelryTypeDao.Instance.UpdateJewelryType(id, entity);
    }
}
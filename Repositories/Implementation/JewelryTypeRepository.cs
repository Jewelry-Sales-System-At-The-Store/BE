using BusinessObjects.Models;
using DAO;
using Repositories.Interface;
using Tools;

namespace Repositories.Implementation;

public class JewelryTypeRepository : IJewelryTypeRepository
{
    public async Task<IEnumerable<JewelryType?>?> Gets()
    {
        return await JewelryTypeDao.Instance.GetJewelryTypes();
    }

    public async Task<JewelryType?> GetById(string id)
    {
        return await JewelryTypeDao.Instance.GetJewelryTypeById(id);
    }

    public async Task<int> Create(JewelryType entity)
    {
        entity.JewelryTypeId = IdGenerator.GenerateId();
        return await JewelryTypeDao.Instance.CreateJewelryType(entity);
    }

    public async Task<int> Update(string id, JewelryType entity)
    {
        return await JewelryTypeDao.Instance.UpdateJewelryType(id, entity);
    }
}
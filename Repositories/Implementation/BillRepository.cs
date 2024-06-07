using AutoMapper;
using BusinessObjects.DTO;
using BusinessObjects.Models;
using DAO;
using Repositories.Interface;

namespace Repositories.Implementation
{
    public class BillRepository : IBillRepository
    {

        public async Task<int> Create(BillDto entity)
        {
            if(entity.JewelryIds == null) return 0;
            var bill = new Bill
            {
                CustomerId = entity.CustomerId,
                UserId = entity.UserId,
                SaleDate = entity.SaleDate,
            };
            var result = await BillDao.Instance.CreateBill(bill);
            if (result > 0)
            {
                foreach (int jewelryId in entity.JewelryIds)
                {
                    var isSold = await JewelryDao.Instance.IsSold(jewelryId);
                    if (isSold)
                    {
                        return 0;
                    }
                    var billJewelry = new BillJewelry
                    {
                        BillId = bill.BillId,
                        JewelryId = jewelryId
                    };
                    result = await BillJewelryDao.Instance.CreateBillJewelry(billJewelry);
                }
            }
            return result;
        }
        public async Task<IEnumerable<Bill?>?> GetAll()
        {
            throw new NotImplementedException();
        }
        public async Task<Bill?> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

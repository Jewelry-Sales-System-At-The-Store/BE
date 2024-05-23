using BusinessObjects.DTO;
using BusinessObjects.Models;
using DAO;
using Repositories.Interface;

namespace Repositories.Implementation
{
    public class BillRepository : IBillRepository
    {
        public async Task<int> Create(BillDTO entity)
        {
            var bill = new Bill
            {
                CustomerId = entity.CustomerId,
                UserId = entity.UserId,
                SaleDate = entity.SaleDate,                    
            };
            var result = await BillDAO.Instance.CreateBill(bill);
            if (result > 0)
            {
                foreach (int jewelryId in entity.JewelryIds)
                {
                    var isSold = await JewelryDAO.Instance.IsSold(jewelryId);
                    if (isSold)
                    {
                        return 0;
                    }
                    var billJewelry = new BillJewelry
                    {
                        BillId = bill.BillId,
                        JewelryId = jewelryId
                    };
                    result = await BillJewelryDAO.Instance.CreateBillJewelry(billJewelry);
                }
            }
            return result;
        }

        public async Task<Bill?> FindBillByCustomerId(int customerId)
        {
            return await BillDAO.Instance.FindBillByCustomerId(customerId);
        }

        public async Task<IEnumerable<Bill?>?> GetAll()
        {
            return await BillDAO.Instance.GetBills();
        }

        public async Task<Bill?> GetById(int id)
        {
            return await BillDAO.Instance.GetBillById(id);
        }
    }
}

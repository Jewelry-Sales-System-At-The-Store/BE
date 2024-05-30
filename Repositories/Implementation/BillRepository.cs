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
            if(entity.JewelryIds == null) return 0;
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
        public async Task<IEnumerable<BillResponseDTO?>?> GetAll2()
        {
            var bills = await BillDAO.Instance.GetBills();
            if (bills == null) return null;

            var billResponses = new List<BillResponseDTO?>();
            foreach (var bill in bills)
            {
                var customer = await CustomerDAO.Instance.GetCustomerByBillId(bill?.BillId);
                var jewelries = await JewelryDAO.Instance.GetJewelriesByBillId(bill?.BillId);
                if (jewelries == null) return null;

                var jewelryResponses = new List<JewelryResponse>();
                foreach (var jewelry in jewelries)
                {
                    var warranty = await WarrantyDAO.Instance.GetWarrantyById(jewelry.WarrantyId);
                    var jewelryType = await JewelryTypeDAO.Instance.GetJewelryTypeById(jewelry.JewelryTypeId);
                    if (warranty == null) return null;

                    var jewelryResponse = new JewelryResponse
                    {
                        JewelryId = jewelry.JewelryId,
                        JewelryType = new JewelryTypeResponse
                        {
                            JewelryTypeId = jewelryType?.JewelryTypeId,
                            Name = jewelryType?.Name
                        },
                        Name = jewelry.Name,
                        Barcode = jewelry.Barcode,
                        BasePrice = jewelry.BasePrice,
                        Weight = jewelry.Weight,
                        LaborCost = jewelry.LaborCost,
                        StoneCost = jewelry.StoneCost,
                        Warranty = new WarrantyResponse
                        {
                            WarrantyId = warranty.WarrantyId,
                            Description = warranty.Description,
                            EndDate = warranty.EndDate
                        }
                    };
                    jewelryResponses.Add(jewelryResponse);
                }

                var billResponse = new BillResponseDTO
                {
                    BillId = bill?.BillId,
                    CustomerId = bill?.CustomerId,
                    CustomerName = customer?.Name,
                    SaleDate = bill?.SaleDate,
                    UserId = bill?.UserId,
                    TotalAmount = 0,
                    Jewelries = jewelryResponses
                };
                billResponses.Add(billResponse);
            }

            return billResponses;
        }

        public async Task<Bill?> GetById(int id)
        {
            return await BillDAO.Instance.GetBillById(id);
        }
        public async Task<BillResponseDTO?> GetById2(int id)
        {
            var customer = await CustomerDAO.Instance.GetCustomerByBillId(id);
            var bill = await BillDAO.Instance.GetBillById(id);
            if (bill == null) return null;
            var jewelries = await JewelryDAO.Instance.GetJewelriesByBillId(id);
            if (jewelries == null) return null;
            List<JewelryResponse> jewelryResponses = new();
            foreach (var jewelry in jewelries)
            {
                var warranty = await WarrantyDAO.Instance.GetWarrantyById(jewelry.WarrantyId);
                var jewelryType = await JewelryTypeDAO.Instance.GetJewelryTypeById(jewelry.JewelryTypeId);

                if (warranty == null) return null;
                var jewelryResponse = new JewelryResponse
                {
                    JewelryId = jewelry.JewelryId,
                    JewelryType = new JewelryTypeResponse
                    {
                        JewelryTypeId = jewelryType?.JewelryTypeId,
                        Name = jewelryType?.Name
                    },
                    Name = jewelry.Name,
                    Barcode = jewelry.Barcode,
                    BasePrice = jewelry.BasePrice,
                    Weight = jewelry.Weight,
                    LaborCost = jewelry.LaborCost,
                    StoneCost = jewelry.StoneCost,
                    Warranty = new WarrantyResponse
                    {
                        WarrantyId = warranty.WarrantyId,
                        Description = warranty.Description,
                        EndDate = warranty.EndDate
                    }
                };
                jewelryResponses.Add(jewelryResponse);
            }

            BillResponseDTO billResponse = new()
            {
                BillId = bill.BillId,
                CustomerId = bill.CustomerId,
                CustomerName = customer?.Name,
                SaleDate = bill.SaleDate,
                UserId = bill.UserId,
                TotalAmount = 0,
                Jewelries = jewelryResponses
            };

            return billResponse;
        }
    }
}

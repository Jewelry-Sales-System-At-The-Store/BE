using AutoMapper;
using BusinessObjects.DTO;
using BusinessObjects.Models;
using DAO;
using Repositories.Interface;
using Repositories.Interface.GenericRepository;

namespace Repositories.Implementation
{
    public class BillRepository : IBillRepository
    {
        private readonly IMapper _mapper;
        public BillRepository(IMapper mapper)
        {
            _mapper = mapper;
        }

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
        public async Task<IEnumerable<BillResponseDTO?>?> GetAll()
        {
            var bills = await BillDAO.Instance.GetBills();
            if (bills == null) return null;

            var billResponses = new List<BillResponseDTO?>();

            foreach (var bill in bills)
            {
                var billResponse = _mapper.Map<BillResponseDTO>(bill);
                billResponses.Add(billResponse);
            }

            return billResponses;
        }
        public async Task<BillResponseDTO?> GetById(int id)
        {
            var bill = await BillDAO.Instance.GetBillById(id);
            return _mapper.Map<BillResponseDTO>(bill);
        }
    }
}

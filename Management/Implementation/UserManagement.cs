using BusinessObjects.Dto;
using BusinessObjects.Dto.Bill;
using BusinessObjects.Models;
using Management.Interface;
using Services.Interface;

namespace Management.Implementation
{
    public class UserManagement(IUserService userService, IBillService billService) : IUserManagement
    {
        private IUserService UserService { get; } = userService;
        private IBillService BillService { get; } = billService;

        public async Task<User?> Login(LoginDto loginDto)
        {
            return await UserService.Login(loginDto);
        }

        public async Task<IEnumerable<User?>?> GetUsers()
        {
            return await UserService.GetUsers();
        }

        public async Task<IEnumerable<Bill?>?> GetBills()
        {
            return await BillService.GetBills();
        }

        public async Task<Bill?> GetBillById(int id)
        {
            return await BillService.GetById(id);
        }

        public async Task<BillResponseDto> CreateBill(BillRequestDto billRequestDto)
        {
            return await BillService.Create(billRequestDto);
        }
    }
}
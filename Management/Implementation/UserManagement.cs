using BusinessObjects.DTO;
using BusinessObjects.DTO.Bill;
using BusinessObjects.DTO.BillReqRes;
using BusinessObjects.DTO.Other;
using BusinessObjects.DTO.ResponseDto;
using BusinessObjects.Models;
using Management.Interface;
using Services.Interface;

namespace Management.Implementation
{
    public class UserManagement(IJewelryService jewelryService,IUserService userService, IBillService billService, ITokenService tokenService) : IUserManagement
    {
        public IJewelryService JewelryService { get; } = jewelryService;
        private IUserService UserService { get; } = userService;
        private IBillService BillService { get; } = billService;
        private ITokenService TokenService { get; } = tokenService;

        public async Task<TokenResponseDto?> Login(LoginDto loginDto)
        {
            var user = await UserService.Login(loginDto);
            if (user == null) return null;
            var token = await TokenService.CreateToken(user);
            return token;
        }

        public async Task<IEnumerable<User?>?> GetUsers()
        {
            return await UserService.GetUsers();
        }

        public async Task<PagingResponse> GetBills(int pageNumber, int pageSize)
        {
            return await BillService.GetBills(pageNumber, pageSize);
        }

        public async Task<BillDetailDto?> GetBillById(string id)
        {
            return await BillService.GetById(id);
        }
        
        public async Task<BillResponseDto> CreateBill(BillRequestDto billRequestDto)
        {
            return await BillService.Create(billRequestDto);
        }

        public async Task<User?> GetUserById(string id)
        {
            return await UserService.GetUserById(id);
        }

        public async Task<int> AddUser(UserDto userDto)
        {
            return await UserService.AddUser(userDto);
        }

        public async Task<int> UpdateUser(string id, UserDto user)
        {
            return await UserService.UpdateUser(id, user);
        }

        public async Task<int> DeleteUser(string id)
        {
            return await UserService.DeleteUser(id);
        }
    }
}
using BusinessObjects.DTO;
using BusinessObjects.DTO.Bill;
using BusinessObjects.DTO.BillReqRes;
using BusinessObjects.DTO.Other;
using BusinessObjects.DTO.ResponseDto;

namespace Management.Interface
{
    public interface IUserManagement
    {
        public Task<TokenResponseDto?> Login(LoginDto loginDto);
        //Bill
        public Task<PagingResponse> GetBills(int pageNumber, int pageSize);
        public Task<BillDetailDto?> GetBillById(string id);
        public Task<BillResponseDto> CreateBill(BillRequestDto billRequestDto);
        //Crud User
        public Task<IEnumerable<UserResponseDto?>?> GetUsers();
        public Task<UserResponseDto?> GetUserById(string id);
        public Task<int> AddUser(UserDto userDto);
        public Task<int> UpdateUser(string id, UserDto userDto);
        public Task<int> DeleteUser(string id);
    }
}

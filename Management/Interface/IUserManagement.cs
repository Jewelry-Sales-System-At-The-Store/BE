﻿using BusinessObjects.Dto;
using BusinessObjects.Dto.BillReqRes;
using BusinessObjects.Dto.Other;
using BusinessObjects.Dto.ResponseDto;

namespace Management.Interface
{
    public interface IUserManagement
    {
        public Task<TokenResponseDto?> Login(LoginDto loginDto);
        //Bill
        public Task<PagingResponse> GetBills(int pageNumber, int pageSize);
        public Task<BillDetailDto?> GetBillById(string id);
        public Task<BillResponseDto> CreateBill(BillRequestDto billRequestDto);
        public Task<BillCashCheckoutResponseDto> CheckoutBill(string id, float cashAmount);
        //Crud User
        public Task<IEnumerable<UserResponseDto?>?> GetUsers();
        public Task<UserResponseDto?> GetUserById(string id);
        public Task<int> AddUser(UserDto userDto);
        public Task<int> UpdateUser(string id, UserDto userDto);
        public Task<int> DeleteUser(string id);
    }
}

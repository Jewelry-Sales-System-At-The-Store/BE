﻿using BusinessObjects.DTO;
using BusinessObjects.Models;

namespace Management.Interface
{
    public interface IUserService
    {
        public Task<User?> Login(LoginDTO loginDTO);
        public Task<IEnumerable<User?>?> GetUsers();
        public Task<bool> IsUser(string email, string password);
    }
}

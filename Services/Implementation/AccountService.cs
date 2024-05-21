using BusinessObjects.Models;
using Repositories.Interface;
using Services.Interface;

namespace Services.Implementation
{
    public class AccountService(IAccountRepository accountRepository) : IAccountService
    {
        //private readonly IAccountRepository _accountRepository = accountRepository;

        //public Account GetAccount(string email, string password)
        //{
        //   return _accountRepository.GetAccount(email, password);
        //}

        //public IEnumerable<Account> GetAccounts()
        //{
        //    var accounts = _accountRepository.GetAccounts();
        //    return accounts;
        //}

        //public bool isUser(string email, string password)
        //{
        //    Account account = _accountRepository.GetAccount(email, password);
        //    if (account == null)
        //    {
        //        return false;
        //    }
        //    return true;
        //}
    }
}

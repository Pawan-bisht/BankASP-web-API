using BankingWebApi.Models;
using BankingWebApi.DTO;
namespace BankingWebApi.Interfaces
{
    public interface IAccountRepository
    {
        List<Account> GetAccounts(string userId);
        List<User> CreateAccount(AccountTransactionDto createAccountDto);
        List<User> DeleteAccount(AccountTransactionDto createAccountDto);
        List<User> Deposite(AccountTransactionDto depositeAccountDto);
        List<User> Withdraw(AccountTransactionDto depositeAccountDto);

    }
}
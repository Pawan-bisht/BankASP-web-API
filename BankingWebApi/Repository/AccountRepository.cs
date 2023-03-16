using BankingWebApi.Interfaces;
using BankingWebApi.Models;
using BankingWebApi.DTO;
using System.Globalization;

namespace BankingWebApi.Repository{
    public class AccountRepository : IAccountRepository
    {
        public List<User> CreateAccount(AccountTransactionDto createAccountDto)
        {
            var first = UserRepository.users.Where(i => i.Id.Equals(createAccountDto.UserId)).First();
            if(createAccountDto.DepositeAmount < 100)
            {
                throw new Exception("Minimum balance in account should be 100$");
            }
            if(createAccountDto.DepositeAmount > 10000){
                throw new Exception("Maximum ammount can diposite in account should not be more than 10000$");
            }
            string dateString = createAccountDto.CreatedDate;
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
            DateTimeStyles styles = DateTimeStyles.None;
            DateTime accountCreatedDate = DateTime.Parse(dateString, culture, styles);
            Random rnd = new Random();
            
            first.Accounts.Add(new Account(rnd.Next(), (long)createAccountDto.DepositeAmount,accountCreatedDate));
            return UserRepository.users;
        }

        public List<User> DeleteAccount(AccountTransactionDto createAccountDto)
        {
            try{
            var user = UserRepository.users.Where(user => user.Id.Equals(createAccountDto.UserId)).First();
            int account = user.Accounts.FindIndex(account => account.AccountNumber == createAccountDto.AccountNumber);
            user.Accounts.RemoveAt(account);
            return UserRepository.users;
            } catch (Exception e){
                throw new Exception("Cant done the operation");
            }
            
        }

        public List<User> Deposite(AccountTransactionDto depositeAccountDto)
        {
            if(depositeAccountDto.DepositeAmount > 10000) {
                throw new Exception("Maximum ammount can diposite in account should not be more than 10000$");
            } 
            var user = UserRepository.users.Where(user => user.Id.Equals(depositeAccountDto.UserId)).First();
            var account = user.Accounts.Where(account => account.AccountNumber.Equals(depositeAccountDto.AccountNumber)).First();
            account.Balance =  (long)(account.Balance + depositeAccountDto.DepositeAmount);
            return UserRepository.users;
        }

        public List<Account> GetAccounts(string userId)
        {
            var first = UserRepository.users.Where(user => user.Id.Equals(userId)).First();
            return first.Accounts;
        }

        public List<User> Withdraw(AccountTransactionDto depositeAccountDto)
        {
            var user = UserRepository.users.Where(user => user.Id.Equals(depositeAccountDto.UserId)).First();
            var account = user.Accounts.Where(account => account.AccountNumber.Equals(depositeAccountDto.AccountNumber)).First();
            
            if(depositeAccountDto.WithdrawAmount > 0.9*account.Balance) {
                throw new Exception("Withdraw ammount cannot be more than 90% of your current deposite");
            } else if((account.Balance - depositeAccountDto.WithdrawAmount) < 100) {
                throw new Exception("Minimum ammount cannot less than 100$");
            } else {
                account.Balance = (long)(account.Balance - depositeAccountDto.WithdrawAmount);
            }
            return UserRepository.users;
        }
    }
}
namespace BankingWebApi.Models
{
    public class Account {
        public long AccountNumber { get; set; }
        public long Balance { get; set; }
        public DateTime CreatedDate {get; set;}
        public Account(long accountNumber, long balance, DateTime createdDate) {
            AccountNumber = accountNumber;
            Balance = balance;
            CreatedDate = createdDate;
        }
    }
}
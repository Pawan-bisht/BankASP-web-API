namespace BankingWebApi.DTO
{
    public class AccountDto {
        public long? AccountNumber { get; set; }
        public long? Balance { get; set; }
        public DateTime? CreatedDate {get; set;}
    }
}
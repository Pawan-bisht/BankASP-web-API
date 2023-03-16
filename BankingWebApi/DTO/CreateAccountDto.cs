namespace BankingWebApi.DTO
{
    public class AccountTransactionDto {
        public long? DepositeAmount { get; set; }
        public long? WithdrawAmount {get; set;}
        public string UserId {get;set;}
        public long? AccountNumber {get;set;}
        public string? CreatedDate {get;set;}
        public string SocialSecurityNumber {get; set;}
    }
}
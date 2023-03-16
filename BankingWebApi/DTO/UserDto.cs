namespace BankingWebApi.DTO
{
    public class UserDto {
        public string? Id { get; set; }
        public string Name { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string DOB { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public IList<AccountDto>? Accounts { get; set;} 
    }
}
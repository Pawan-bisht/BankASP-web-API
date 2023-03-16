namespace BankingWebApi.Models
{
    public class User {
        public string Id { get; set; }
        public string Name { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public List<Account> Accounts { get; set;}
        public User(string id, string name, string ssn, string phoneNumber, DateTime dob, string address, int age){
            Id = id;
            Name = name;
            SocialSecurityNumber = ssn;
            PhoneNumber = phoneNumber;
            DOB = dob;
            Address = address;
            Age = age;
            Accounts = new List<Account>();
        }
    }
}
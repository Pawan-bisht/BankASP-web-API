namespace BankingWebApi.Test.MockData;
using BankingWebApi.Models;
using BankingWebApi.DTO;

public class UsersMockData{
    public static List<UserDto> GetUsers() 
    {
        return  new List<UserDto>{
                new UserDto {
                    Id =  "828525cb-cfe5-4f8f-8485-f9fe6f6b13d2",
                    Name = "John",
                    SocialSecurityNumber = "DQJPB34581H",
                    PhoneNumber = "345893812229",
                    DOB= "2009-03-01T10:00:00",
                    Address = "C-6 House Number 48 4th floor",
                    Age = 100,
                    Accounts = new List<AccountDto>()
                },
                new UserDto {
                    Id = "d2ac4a1f-878d-44ba-a5db-cff253c598b0",
                    Name = "Jonathan",
                    SocialSecurityNumber = "DQJPB34581H",
                    PhoneNumber = "345893812229",
                    DOB = "01/03/2009 10:00:00 AM",
                    Address = "C-6 House Number 48 4th floor",
                    Age =  100,
                    Accounts = new List<AccountDto>{
                        new AccountDto {
                            AccountNumber = 999893556,
                            Balance = 6000,
                            CreatedDate = DateTime.Parse("2009-12-01T10:00:00")
                        },
                        new AccountDto{
                            AccountNumber = 553338760,
                            Balance = 9000,
                            CreatedDate = DateTime.Parse("2009-12-01T10:00:00")
                        }
                    }
                },
                
                new UserDto{
                    Id = "f8964d62-4073-4f21-bfd1-f2c334e84ea5",
                    Name ="Merry",
                    SocialSecurityNumber = "DQJPB34581H",
                    PhoneNumber = "345893812229",
                    DOB = "01/03/2009 10:00:00 AM",
                    Address = "C-6 House Number 48 4th floor",
                    Age = 100,
                    Accounts = new List<AccountDto>{
                        new AccountDto{
                            AccountNumber = 1687629218,
                            Balance= 150,
                            CreatedDate = DateTime.Parse("2009-12-01T10:00:00")
                        }
                    }
                }
    }; }
}
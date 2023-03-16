using BankingWebApi.Interfaces;
using BankingWebApi.Models;
using BankingWebApi.DTO;
using System.Globalization;

namespace BankingWebApi.Repository
{
    
    public class UserRepository : IUserRepository
    {
        
        public static List<User> users = new List<User>();
        public User CreateUser(UserDto user)
        {
            System.Guid guid = System.Guid.NewGuid();
            var id = guid.ToString();
            string dateString = user.DOB;
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
            DateTimeStyles styles = DateTimeStyles.None;
            DateTime dob = DateTime.Parse(dateString, culture, styles);
            User newUser = new User(id, user.Name, user.SocialSecurityNumber, user.PhoneNumber, dob, user.Address, user.Age);
            try{
                users.Add(newUser);
            } catch(Exception ex){
                Console.WriteLine(ex);
            }
            return newUser;
        }

        public List<User> GetUsers()
        {
            return users;
        }
    }
}
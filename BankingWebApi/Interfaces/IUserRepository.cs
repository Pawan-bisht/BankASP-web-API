using BankingWebApi.Models;
using BankingWebApi.DTO;
namespace BankingWebApi.Interfaces
{
    public interface IUserRepository {

        User CreateUser(UserDto user);
        List<User> GetUsers();

    }
}
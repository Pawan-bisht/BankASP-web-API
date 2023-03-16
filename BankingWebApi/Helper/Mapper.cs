using AutoMapper;
using BankingWebApi.DTO;
using BankingWebApi.Models;

namespace BankingWebApi.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<User, UserDto>();
            CreateMap<Account, AccountDto>();
        }
    }
}
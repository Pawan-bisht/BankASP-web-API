
using BankingWebApi.DTO;
using BankingWebApi.Interfaces;
using BankingWebApi.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
namespace BankingWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BankController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IAccountRepository _accountRepository;
        private readonly IMapper _mapper;

        public BankController(IUserRepository userRepository, IAccountRepository accountRepository, IMapper mapper)
        {
            _userRepository = userRepository; // dependency injection
            _accountRepository = accountRepository; // dependency injection
            _mapper = mapper; // dependency injection
        }

        [HttpGet]
        [Route("all-users")]
        public IActionResult GetUsers()
        {

            var users = _mapper.Map<List<UserDto>>(_userRepository.GetUsers());
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(users);
        }

        [Route("create-user")]
        [HttpPost]
        public IActionResult CreateUser([FromBody] UserDto user)
        {
            var res = _userRepository.CreateUser(user);
            var result =  _mapper.Map<User, UserDto>(res);
            if (!ModelState.IsValid)
                        return BadRequest(ModelState);

            return Ok(result);
        }

        [Route("get-accounts")]
        [HttpGet]
        public IActionResult GetAccounts([FromQuery] string userId)
        {
            return Ok(_mapper.Map<List<AccountDto>>(_accountRepository.GetAccounts(userId)));
        }

        [HttpPost]
        [Route("create-account")]
        public IActionResult CreateAccount([FromBody] AccountTransactionDto account)
        {
            List<UserDto> result;
            try{
                result = _mapper.Map<List<UserDto>>(_accountRepository.CreateAccount(account));

            } catch (Exception e){
                throw new Exception(e.Message);
            }
            return Ok(result);
        }

        [HttpPost]
        [Route("delete-account")]
        public IActionResult DeleteAccount([FromBody] AccountTransactionDto account)
        {
            List<UserDto> result;
            try{
                result = _mapper.Map<List<UserDto>>(_accountRepository.DeleteAccount(account));
            } catch (Exception e){
                throw new Exception(e.Message);
            }
            return Ok(result);
        }

        [HttpPost]
        [Route("withdraw-amount")]
        public IActionResult WithdrawAmount([FromBody] AccountTransactionDto account)
        {
            List<UserDto> result;
            try{
                result = _mapper.Map<List<UserDto>>(_accountRepository.Withdraw(account));
            } catch (Exception e){
                throw new Exception(e.Message);
            }
            return Ok(result);
        }

        [HttpPost]
        [Route("deposite-amount")]
        public IActionResult DepositeAmount([FromBody] AccountTransactionDto account)
        {
            List<UserDto> result;
            try{
                result = _mapper.Map<List<UserDto>>(_accountRepository.Deposite(account));
            } catch (Exception e){
                throw new Exception(e.Message);
            }
            return Ok(result);
        }
    }
}

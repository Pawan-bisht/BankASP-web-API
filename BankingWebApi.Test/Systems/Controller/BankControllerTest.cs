using BankingWebApi.Interfaces;
using BankingWebApi.DTO;
using FluentAssertions;
using FakeItEasy;
using AutoMapper;
using BankingWebApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using BankingWebApi.Models;

namespace BankingWebApi.Test.Systems.Controller;

public class TestBankController {

    private readonly IAccountRepository _accountRepository;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
    [Fact]
    public void BankController_GetUsers_ShouldReturn200Status() {
        
        //Arrange
        var users = A.Fake<ICollection<UserDto>>();
        var usersList = A.Fake<List<UserDto>>();
        A.CallTo(()=>_mapper.Map<List<UserDto>>(users)).Returns(usersList);
        var controller = new BankController(_userRepository, _accountRepository, _mapper);  
        
        //Act
        var result = controller.GetUsers(); 
              
        //Assert
        result.Should().NotBeNull();
        result.Should().BeOfType(typeof(OkObjectResult));
    }

    [Fact]
    public void BankController_CreateUser_ShouldReturn200status() {
        //Arrange
        var user = A.Fake<User>();
        var createdUser = A.Fake<UserDto>();
        A.CallTo(()=>_mapper.Map<UserDto>(user)).Returns(createdUser);
        var controller = new BankController(_userRepository, _accountRepository, _mapper);  
        //Act
        Console.WriteLine( );
        
        var result = controller.CreateUser(createdUser); 
        
        //Assert
        result.Should().NotBeNull();
        result.Should().BeOfType(typeof(OkObjectResult));
    }

    [Fact] void BankController_GetAccounts_ShouldReturn200status() {
        //Arrange
        var userId = "2b595f21-9597-4476-ba78-b4045292f4ba";
        var accounts = A.Fake<ICollection<AccountDto>>();
        var returnedAccount = A.Fake<List<AccountDto>>();
        A.CallTo(()=>_mapper.Map<List<AccountDto>>(accounts)).Returns(returnedAccount);
        var controller = new BankController(_userRepository, _accountRepository, _mapper);  
        //Act
        var result = controller.GetAccounts(userId);
        // Console.WriteLine(typeof(result));
        Console.WriteLine(typeof(OkObjectResult));

        //Assert
        result.Should().NotBeNull();
        result.Should().BeOfType(typeof(OkObjectResult));
    }

    [Fact] 
    void BankController_CreateAccount_ShouldReturn200status() {
        //Arrange
        var accountDto = A.Fake<AccountTransactionDto>();
        var userList = A.Fake<List<User>>();
        var userDtoList = A.Fake<List<UserDto>>();
        A.CallTo(()=>_mapper.Map<List<UserDto>>(userList)).Returns(userDtoList);
        var controller = new BankController(_userRepository, _accountRepository, _mapper);  
        //Act
        var result = controller.CreateAccount(accountDto);
        //Assert
        result.Should().NotBeNull();
        result.Should().BeOfType(typeof(OkObjectResult));
    }

    [Fact] 
    void BankController_DeleteAccount_ShouldReturn200status() {
        //Arrange
        var accountDto = A.Fake<AccountTransactionDto>();
        var userList = A.Fake<List<User>>();
        var userDtoList = A.Fake<List<UserDto>>();
        A.CallTo(()=>_mapper.Map<List<UserDto>>(userList)).Returns(userDtoList);
        var controller = new BankController(_userRepository, _accountRepository, _mapper);  
        //Act
        var result = controller.DeleteAccount(accountDto);
        //Assert
        result.Should().NotBeNull();
        result.Should().BeOfType(typeof(OkObjectResult));
    }

    [Fact] 
    void BankController_WithdrawAmount_ShouldReturn200status() {
        //Arrange
        var accountDto = A.Fake<AccountTransactionDto>();
        var userList = A.Fake<List<User>>();
        var userDtoList = A.Fake<List<UserDto>>();
        A.CallTo(()=>_mapper.Map<List<UserDto>>(userList)).Returns(userDtoList);
        var controller = new BankController(_userRepository, _accountRepository, _mapper);  
        //Act
        var result = controller.WithdrawAmount(accountDto);
        //Assert
        result.Should().NotBeNull();
        result.Should().BeOfType(typeof(OkObjectResult));
    }

    [Fact] 
    void BankController_DepositeAmount_ShouldReturn200status() {
        //Arrange
        var accountDto = A.Fake<AccountTransactionDto>();
        var userList = A.Fake<List<User>>();
        var userDtoList = A.Fake<List<UserDto>>();
        A.CallTo(()=>_mapper.Map<List<UserDto>>(userList)).Returns(userDtoList);
        var controller = new BankController(_userRepository, _accountRepository, _mapper);  
        //Act
        var result = controller.DepositeAmount(accountDto);
        //Assert
        result.Should().NotBeNull();
        result.Should().BeOfType(typeof(OkObjectResult));
    }




    public TestBankController(){
        _accountRepository = A.Fake<IAccountRepository>();
        _userRepository = A.Fake<IUserRepository>();
        _mapper = A.Fake<IMapper>();    
    }
}

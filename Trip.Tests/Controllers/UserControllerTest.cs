using System.Data;
using Internal;
using System.Runtime.InteropServices;
using System.Reflection;
using System;
using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;
using Trip.Services.Interfaces;
using Trip.API.Controllers;
using Trip.API.ViewModels;
using Trip.Data.Models;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using Trip.Services.DTO;
using Trip.Api.ViewModels;
using System.Threading.Tasks;




namespace Trip.Test.Controllers
{
    public class UserControllerTest
    {
        private readonly Mock<IUserService> _mockUserService;
        private readonly Mock<IMapper> _mockMapper;
        private readonly UserController _controller;

        public UserControllerTest()
        {
            _mockMapper = new Mock<IMapper>();
            _mockUserService = new Mock<IUserService>();
            _controller = new UserController(_mockUserService.Object, _mockMapper.Object);
        }

        [Fact]
        public void TestGetUserByEmail()
        {
            // Arrange
            var user = new UserDTO
            {
                Email = "firas@Test.com",
                Password = "123456",
                FirstName = "Firas",
                LastName = "Trabelsi",
                PhoneNumber = "23569748"
            };

            _mockUserService.Setup(x => x.GetUserByEmail(It.IsAny<string>())).Returns(user);

            // Act
            var result = _controller.GetUserByEmail("firas@Test.com");

            // Assert
            Assert.NotNull(result);
            // Check if the result is an OkObjectResult
            var okResult = Assert.IsType<OkObjectResult>(result);
            var userTest = Assert.IsAssignableFrom<UserDTO>(okResult.Value); // Assuming User is the type returned by your action

            // Now you can access properties of the user object
            Assert.Equal("firas@Test.com", userTest.Email);
            Assert.Equal("Firas", userTest.FirstName);
            Assert.Equal("123456", userTest.Password);
            Assert.Equal("23569748", userTest.PhoneNumber);

        }
        [Fact]
        public async void GetUserList_Returns_Ok_With_User_List()
        {
            // Arrange
            var users = new List<UserDTO>
            {
                new UserDTO
                {
                    Id = Guid.NewGuid(),
                    Email = "user1@test.com",
                    FirstName = "User1",
                    LastName = "Last1"
                },
                new UserDTO
                {
                    Id = Guid.NewGuid(),
                    Email = "user2@test.com",
                    FirstName = "User2",
                    LastName = "Last2"
                }
            };

            _mockUserService.Setup(x => x.GetAllUsers()).Returns(users);

            // Act
            var result = _controller.GetUserList();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var userList = Assert.IsAssignableFrom<IEnumerable<UserDTO>>(okResult.Value);
            var firstUser = userList.FirstOrDefault();
            var count = userList.Count();
            Assert.NotNull(result);
            Assert.Equal("User1", firstUser.FirstName);
            Assert.Equal(2, count);

        }

        [Fact]
        public async void CreateUser_Returns_Ok_If_User_Created_Successfully()
        {
            // Arrange
            _mockUserService.Setup(x => x.Register(It.IsAny<UserDTO>())).Returns(true);
            var userData = new UserViewModelData
            {
                Email = "test@example.com",
                Password = "password",
                FirstName = "John",
                LastName = "Doe",
                PhoneNumber = "1234567890",
                PassportNumber = "AB123456",
                Adresse = "123 Main St"
            };

            // Act
            var result = _controller.CreateUser(userData);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.True((bool)okResult.Value); // Assuming the value returned is a boolean indicating success
            _mockUserService.Verify(x => x.Register(It.IsAny<UserDTO>()), Times.Once); // Verify that the Register method of IUserService was called once with any user DTO
        }


        [Fact]
        public async void Login_Returns_Ok_With_User_If_Valid_Credentials()
        {
            // Arrange
            var expectedClient = new ClientDTO(); // Create a client object for expected result
            _mockUserService.Setup(x => x.GetUserByEmailAndPassword(It.IsAny<string>(), It.IsAny<string>())).Returns(expectedClient);
            var userData = new UserLoginViewModel
            {

            };

            // Act
            var result = _controller.Login(userData);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var client = Assert.IsAssignableFrom<ClientDTO>(okResult.Value);
        }
    }
}

using Xunit;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Trip.Data.Interfaces;
using Trip.Data.Models;
using Trip.Data.Repositories;
using Trip.Data;
using System.Threading.Tasks;
using Trip.Tests.PlatData;
namespace Trip.Tests.Repositories
{
    public class UserRepositoryTests
    {
        private readonly Mock<DbContextClass> _dbContextMock;
        private readonly UserRepository _userRepository;
        public UserRepositoryTests()
        {
            _dbContextMock = new Mock<DbContextClass>();

            _userRepository = new UserRepository(_dbContextMock.Object);
        }
        [Fact]
        public void GetByEmail_ReturnsExpectedResult()
        {
            // Arrange
            var users = DataHelper.GetTestUsers().AsQueryable();
            _dbContextMock.Setup(c => c.Set<User>()).Returns(DataHelper.MockDbSet(users));

            // Act
            var user =  _userRepository.GetByEmail("unit.tester1@abc.com");

            // Assert
            Assert.NotNull(user);
            Assert.Equal("Unit Tester 1", user.FirstName);
        }

         [Fact]
        public void CreateUser_ReturnsExpectedResult()
        {

            // Arrange
            var users = DataHelper.GetTestUsers().AsQueryable();
            _dbContextMock.Setup(c => c.Set<User>()).Returns(DataHelper.MockDbSet(users));

            // Act
            _userRepository.AddRangeUser(users.First());

            // Assert
            _dbContextMock.Verify(x => x.Set<User>().AddRange(users.First()), Times.Once);
        } 


    }
}

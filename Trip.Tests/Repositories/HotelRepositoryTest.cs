using Internal;
 using Moq;
using Xunit;
using Trip.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trip.Api.ViewModels;
using Trip.Tests.PlatData;
using Trip.Data.Repositories;
using Trip.Data;
namespace Trip.Tests.Repositories
{
   
    public class HotelRepositoryTest
    {
        private readonly HotelRepository _hotelRepositoryRepository;
        private readonly Mock<DbContextClass> _dbContextMock;
        public HotelRepositoryTest()
        {
            _dbContextMock = new Mock<DbContextClass>();
            _hotelRepositoryRepository = new HotelRepository(_dbContextMock.Object);
        }

         [Fact]
        public  void GetAll_ReturnsExpectedResult()
        {
            // Arrange
            Guid hotelId = Guid.NewGuid();
            var testData = DataHelper.GetTestHotels(hotelId).AsQueryable();

            // Mock DbSet
            _dbContextMock.Setup(c => c.Set<Hotel>()).Returns(DataHelper.MockDbSet(testData));

            // Act
            var result =  _hotelRepositoryRepository.GetHotelById(testData.First().Id);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(testData.First().Name, result.Name);
        } 

        [Fact]
        public  void GetHotelById_ReturnsExpectedResult()
        {
            // Arrange
            var HotelId = Guid.NewGuid();
            var testData = DataHelper.GenerateFakeHotels( HotelId ).AsQueryable();

           // Mock DbSet
            _dbContextMock.Setup(c => c.Set<Hotel>())
              .Returns(DataHelper.MockDbSet<Hotel>(testData));

            // Act
          var result =  _hotelRepositoryRepository.GetHotelById(HotelId);

            // Assert
              Assert.NotNull(result);
              Assert.Equal("Hotel 1", result.Name);
        }

        

    }}
using System.Net.Http.Headers;
using System.Data;
using Internal;
using Moq;
using Xunit;
using Trip.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trip.Data.Repositories;
using Trip.Data;
using Trip.Tests.PlatData;
namespace Trip.Tests.Repositories
{
    public class AirportServiceTest
    {
        private readonly AirportRepository _airportRepository;
        private readonly Mock<DbContextClass> _dbContextMock;
        public AirportServiceTest()
        {
            _dbContextMock = new Mock<DbContextClass>();
            _airportRepository = new AirportRepository(_dbContextMock.Object);
        }

        [Fact]
        public  void GetAllAirports_ReturnsExpectedResult()
        {
            // Arrange
            var testData = DataHelper.GenerateAirports().AsQueryable();

            // Mock DbSet
            _dbContextMock.Setup(c => c.Set<Airport>()).Returns(DataHelper.MockDbSet(testData));


            // Act
            var result = _airportRepository.GetAllAirportsDetails();


            // Assert
            Assert.NotNull(result);

        }
    }
}
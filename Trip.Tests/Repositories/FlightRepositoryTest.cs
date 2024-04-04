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
    public class FlightRepositoryTest
    {
        private readonly FlightRepository _flightRepository;
        private readonly Mock<DbContextClass> _dbContextMock;
        public FlightRepositoryTest()
        {
            _dbContextMock = new Mock<DbContextClass>();
            _flightRepository = new FlightRepository(_dbContextMock.Object);
        }
        [Fact]
        public  void GetAllFlights_ReturnsExpectedResult()
        {
            // Arrange
            var testData = DataHelper.GenerateFlights().AsQueryable();

            // Mock DbSet
            _dbContextMock.Setup(c => c.Set<Flight>()).Returns(DataHelper.MockDbSet(testData));


            // Act
            var result = _flightRepository.GetAllFlightsDetails();


            // Assert
            Assert.NotNull(result);

        }
    }
}
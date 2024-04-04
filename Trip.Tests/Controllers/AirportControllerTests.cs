using Xunit;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trip.API.Controllers;
using Trip.Services.Interfaces;
using Trip.Data.Models;
using System.Linq;
using AutoMapper;
using Trip.Services.DTO;
using Trip.Api.ViewModels;
namespace Trip.Tests.Controllers
{
    public class AirportControllerTests
    {
        private readonly AirportController _controller;
        private readonly Mock<IAirportService> _mockAirportService;
        private readonly Mock<IMapper> _mockMapper;

        public AirportControllerTests()
        {
            _mockAirportService = new Mock<IAirportService>();
            _mockMapper = new Mock<IMapper>();
            _controller = new AirportController(_mockAirportService.Object, _mockMapper.Object);
        }

        [Fact]
        public void GetAirportList_Returns_Ok_With_AirportList()
        {
            // Arrange
            var expectedAirports = new List<AirportDTO>
    {
        new AirportDTO { Id = Guid.NewGuid(), Name = "Airport 1", Code = "A1" },
        new AirportDTO { Id = Guid.NewGuid(), Name = "Airport 2", Code = "A2" }
    };

            _mockAirportService.Setup(x => x.GetAllAirports()).Returns(expectedAirports);

            var expectedMappedAirports = expectedAirports.Select(a => new AirportViewModel
            {
                Id = a.Id,
                Name = a.Name,
                Code = a.Code
            });

            _mockMapper.Setup(m => m.Map<IEnumerable<AirportViewModel>>(expectedAirports)).Returns(expectedMappedAirports);

            // Act
            var result = _controller.GetAirportList();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnedAirports = Assert.IsAssignableFrom<IEnumerable<AirportViewModel>>(okResult.Value);
            Assert.Equal(expectedMappedAirports.Count(), returnedAirports.Count());
        }
    }
}

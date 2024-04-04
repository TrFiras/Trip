using Xunit;
using Moq;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trip.API.Controllers;
using Trip.Services.Interfaces;
using Trip.Data.Models;
using Trip.API.ViewModels;
using System.Linq;
using Trip.Services.DTO;
using Trip.Api.ViewModels;


namespace Trip.Tests.Controllers
{
    public class FlightsControllerTests
    {
        private readonly FlightsController _controller;
        private readonly Mock<IFlightService> _mockFlightService;
        private readonly Mock<IMapper> _mockMapper;

        public FlightsControllerTests()
        {
            _mockFlightService = new Mock<IFlightService>();
            _mockMapper = new Mock<IMapper>();
            _controller = new FlightsController(_mockFlightService.Object, _mockMapper.Object);
        }

        [Fact]
        public void GetFlightsList_Returns_Ok_With_FlightsList()
        {
            // Arrange
            var expectedFlights = new List<FlightDTO>
                {
                    new FlightDTO { Id = Guid.NewGuid(), FlightDate = DateTime.Now, FlightNumber = "Flight 1" },
                    new FlightDTO { Id = Guid.NewGuid(), FlightDate = DateTime.Now, FlightNumber = "Flight 2" }
                };

            var mappedFlights = expectedFlights.Select(f => new FlightViewModel
            {
                FlightDate = f.FlightDate,
                FlightNumber = f.FlightNumber
            });

            _mockFlightService.Setup(x => x.GetAllFlights()).Returns(expectedFlights); // Mock returns pre-mapped collection
            _mockMapper.Setup(m => m.Map<IEnumerable<FlightViewModel>>(expectedFlights)).Returns(mappedFlights);

            // Act
            var result = _controller.GetFlightsList();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnedFlights = Assert.IsAssignableFrom<IEnumerable<FlightDTO>>(okResult.Value);
        }

        [Fact]
        public void GetFlightsList_Returns_NotFound_When_FlightsList_Null()
        {
            // Arrange
            _mockFlightService.Setup(x => x.GetAllFlights()).Returns((IEnumerable<FlightDTO>)null);

            // Act
            var result =  _controller.GetFlightsList();

            // Assert
            var notFoundResult = Assert.IsType<NotFoundResult>(result);
            Assert.Equal(404, notFoundResult.StatusCode);
        }
    }
}

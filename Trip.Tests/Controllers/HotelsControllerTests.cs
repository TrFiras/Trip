using Xunit;
using Moq;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq; 
using System.Threading.Tasks;
using Trip.API.Controllers;
using Trip.Services.Interfaces;
using Trip.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Trip.Api.ViewModels;
using Trip.Services.DTO;
using Microsoft.Extensions.Logging;

namespace Trip.Test.Controllers
{


    public class HotelsControllerTests
    {
        private readonly HotelsController _controller;
        private readonly Mock<IHotelService> _mockHotelService;
        private readonly Mock<IMapper> _mockMapper;

        public HotelsControllerTests() {

            _mockMapper = new Mock<IMapper>();
            _mockHotelService = new Mock<IHotelService>();
            _controller = new HotelsController(_mockHotelService.Object, _mockMapper.Object);
        }
        
        [Fact]
        public void GetHotelsList_Returns_Ok_With_HotelsList()
        {
            // Arrange

            // Mock data
            var expectedHotels = new List<HotelDTO>
            {
                new HotelDTO { Id = Guid.NewGuid(), Name = "Hotel 1", Rating = 4.5 },
                new HotelDTO { Id = Guid.NewGuid(), Name = "Hotel 2", Rating = 3.9 }
            };

            _mockHotelService.Setup(x => x.GetAllHotels()).Returns(expectedHotels);

            var expectedMappedHotels = expectedHotels.Select(h => new HotelViewModel
            {
                Id = h.Id,
                Name = h.Name,
                Rating = h.Rating
            });

            _mockMapper.Setup(m => m.Map<IEnumerable<HotelViewModel>>(expectedHotels)).Returns(expectedMappedHotels);

            // Act
            var result = _controller.GetHotelsList();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnedHotels = Assert.IsAssignableFrom<IEnumerable<HotelViewModel>>(okResult.Value);
            Assert.Equal(expectedMappedHotels.Count(), returnedHotels.Count());
        }

[Fact]
public void GetHotelsList_Returns_NotFound_When_HotelsList_Is_Null()
{
    // Arrange
    var mockHotelService = new Mock<IHotelService>();
    var mockMapper = new Mock<IMapper>();

    // Mock data
    IEnumerable<HotelDTO> hotelsList = null;

    mockHotelService.Setup(x => x.GetAllHotels()).Returns(hotelsList);

    var controller = new HotelsController(mockHotelService.Object, mockMapper.Object);

    // Act
    var result =  controller.GetHotelsList();

    // Assert
    Assert.NotNull(result);
    Assert.IsType<NotFoundResult>(result);
}



    }
}

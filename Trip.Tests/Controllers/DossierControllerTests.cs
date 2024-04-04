using Microsoft.Extensions.Configuration;
using Xunit;
using Moq;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trip.API.Controllers;
using Trip.Api.ViewModels;
using Trip.Services.Interfaces;
using Trip.Services.DTO;
using Trip.Data.Models;
using Trip.Data.Interfaces;
using Microsoft.Extensions.Logging;
using System.Linq;
using Trip.API.ViewModels;


namespace Trip.Tests.Controllers
{
    public class DossierControllerTests : IDisposable
    {
        private readonly DossierController _controller;
        private readonly Mock<IDossierService> _mockDossierService;
        private readonly Mock<IMapper> _mockMapper;

        public DossierControllerTests()
        {
            _mockDossierService = new Mock<IDossierService>();
            _mockMapper = new Mock<IMapper>();
            _controller = new DossierController(Mock.Of<ILogger<DossierController>>(), _mockMapper.Object,
                                    _mockDossierService.Object, Mock.Of<IConfiguration>() );
        }

        public void Dispose()
        {
            // Clean up resources if needed
        }

        [Fact]
        public void CreateDossier_Returns_CreatedAtAction_Result()
        {
            // Arrange

            var dossier = new TripDossierViewModel
            {
                Id = Guid.NewGuid(),
                DossierNumber = "1",
                ClientId = Guid.NewGuid(),
            };


            // Act
            var result =  _controller.CreateDossier(dossier);

            // Assert
            var createdAtActionResult = Assert.IsType<CreatedAtActionResult>(result.Result);
            Assert.Equal(nameof(_controller.GetAll), createdAtActionResult.ActionName);
        }

        [Fact]
        public void GetAll_Returns_Ok_With_DossierList()
        {
            // Arrange
            var expectedDossiers = new List<DossierDTO>
                {
                    new DossierDTO { Id = Guid.NewGuid(), DossierNumber = "Dossier 1" },
                    new DossierDTO { Id = Guid.NewGuid(), DossierNumber = "Dossier 2" }
                };

            _mockDossierService.Setup(x => x.GetAll()).Returns(expectedDossiers);

            var expectedMappedDossiers = expectedDossiers.Select(h => new TripDossierViewModel
            {
                Id = h.Id,
                DossierNumber = h.DossierNumber
            });

            _mockMapper.Setup(m => m.Map<IEnumerable<TripDossierViewModel>>(expectedDossiers)).Returns(expectedMappedDossiers);

            // Act
            var result = _controller.GetAll();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnedDossiers = Assert.IsAssignableFrom<IEnumerable<TripDossierViewModel>>(okResult.Value);
            Assert.Equal(expectedMappedDossiers.Count(), returnedDossiers.Count());
        }

        [Fact]
        public void GetDossiersByClientName_Returns_Ok_With_DossierList()
        {
            // Arrange
            var firstName = "John";
            var lastName = "Doe";
            var expectedDossiers = new List<DossierDTO>
            {
                new DossierDTO { Id = Guid.NewGuid(), DossierNumber = "Dossier 1" },
                    new DossierDTO { Id = Guid.NewGuid(), DossierNumber = "Dossier 2" }
                };
            _mockDossierService.Setup(x => x.GetDossiersByClientName(firstName, lastName)).Returns(expectedDossiers);

            var expectedMappedDossiers = expectedDossiers.Select(h => new TripDossierViewModel
            {
                Id = h.Id,
                DossierNumber = h.DossierNumber
            });

            _mockMapper.Setup(m => m.Map<IEnumerable<TripDossierViewModel>>(expectedDossiers)).Returns(expectedMappedDossiers);

            // Act
            var result =  _controller.GetDossiersByClientName(firstName, lastName);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnedDossiers = Assert.IsAssignableFrom<IEnumerable<TripDossierViewModel>>(okResult.Value);
            Assert.Equal(expectedDossiers.Count, returnedDossiers.Count());
        }

        [Fact]
        public void BookRoom_Returns_Ok_With_BookedRoomInfo()
        {
            // Arrange
            var dateDebut = DateTime.UtcNow;
            var dateFin = dateDebut.AddDays(1);
            var userId = Guid.NewGuid();
            var myBookedRooms = new List<RoomDTO>();

            var expectedBookedRoomInfo = new BookedRoomInfoDTO
            {
                TotalAmount = "100", // Assuming TotalAmount is a string
                CountRooms = 2 // Assuming CountRooms is an integer
            };

            _mockMapper.Setup(m => m.Map<BookedRoomInfoViewModel>(expectedBookedRoomInfo))
                .Returns(new BookedRoomInfoViewModel
                {
                    TotalAmount = expectedBookedRoomInfo.TotalAmount,
                    CountRooms = expectedBookedRoomInfo.CountRooms
                });

            _mockDossierService.Setup(x => x.BookRoom(dateDebut, dateFin, userId, myBookedRooms))
                .Returns(expectedBookedRoomInfo);

            // Act
            var result = _controller.BookRoom(dateDebut, dateFin, userId, myBookedRooms);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var bookedRoomInfoViewModel = Assert.IsType<BookedRoomInfoViewModel>(okResult.Value);
            Assert.Equal(expectedBookedRoomInfo.TotalAmount, bookedRoomInfoViewModel.TotalAmount);
            Assert.Equal(expectedBookedRoomInfo.CountRooms, bookedRoomInfoViewModel.CountRooms);
        }
    }
}

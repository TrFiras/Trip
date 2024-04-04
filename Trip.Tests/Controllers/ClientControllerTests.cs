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
using Trip.Services.DTO;
using AutoMapper;
using Trip.Api.ViewModels;

namespace Trip.Tests.Controllers
{
    public class ClientControllerTests
    {
        private readonly Mock<IClientService> _mockClientService;
        private readonly ClientController _controller;
        private readonly Mock<IMapper> _mockMapper;

        public ClientControllerTests()
        {
            _mockClientService = new Mock<IClientService>();
            _controller = new ClientController(_mockClientService.Object, null);
            _mockMapper = new Mock<IMapper>();
        }

       

        [Fact]
        public void GetClientList_Returns_NotFound_When_ClientsListIsNull()
        {
            // Arrange
            _mockClientService.Setup(x => x.GetAllClients()).Returns((IEnumerable<ClientDTO>)null);

            // Act
            var result = _controller.GetClientList();

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Moq;
using Org.BouncyCastle.Ocsp;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Trip.Data;
using Trip.Data.Interfaces;
using Trip.Data.Models;
using Trip.Data.Repositories;
using Trip.Tests.PlatData;
using Xunit;
using static HotChocolate.ErrorCodes;
using System.Net.Sockets;

namespace Trip.Tests.Repositories
{
    public class ClientRepositoryTests
    {

        private readonly ClientRepository _clientRepository;
        private readonly Mock<DbContextClass> _dbContextMock;
        public ClientRepositoryTests() {

            _dbContextMock = new Mock<DbContextClass>();
            _clientRepository = new ClientRepository(_dbContextMock.Object);
    
    }


        [Fact]
        public void Test_CreateClientWithUser()
        {
            var id = Guid.NewGuid();
            // Arrange
            var testDataUser = DataHelper.ArrangeUser(id);
            var testDataClient = DataHelper.ArrangeClient(id);

            _dbContextMock.Setup(c => c.Set<Client>())
                                .Returns(DataHelper.MockDbSet(testDataClient));
            _dbContextMock.Setup(c => c.Set<User>())
                                .Returns(DataHelper.MockDbSet(testDataUser));

            // Act
            _clientRepository.CreateClientWithUser(testDataClient.First(), testDataUser.First());

            //Assert
            _dbContextMock.Verify(x => x.Set<Client>().AddRange(testDataClient.First()), Times.Once);
            _dbContextMock.Verify(x => x.Set<User>().AddRange(testDataUser.First()), Times.Once);
        } 
    }

   
}

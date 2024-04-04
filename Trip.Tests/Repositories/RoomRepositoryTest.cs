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
    public class RoomRepositoryTest
    {
        private readonly RoomRepository _roomRepository;
        private readonly Mock<DbContextClass> _dbContextMock;
        public RoomRepositoryTest()
        {
            _dbContextMock = new Mock<DbContextClass>();
            _roomRepository = new RoomRepository(_dbContextMock.Object);
        }
        public void GetRoomById_ReturnsExpectedResult()
        {
            // Arrange
            var RoomId = Guid.NewGuid();
            var testData = DataHelper.GenerateFakeRooms(RoomId);

            // Mock DbSet
            _dbContextMock.Setup(c => c.Set<Room>())
                          .Returns(DataHelper.MockDbSet<Room>(testData.AsQueryable()));

            // Act
            var result = _roomRepository.GetById(RoomId);

            // Assert
            Assert.NotNull(result);
        }
    }
}
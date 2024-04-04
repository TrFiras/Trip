using System.Runtime.Serialization;
using System.Reflection.Emit;
using System.Data;
using Internal;
using System.Collections.Generic;
using Moq;
using Xunit;
using Trip.Data.Models;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trip.Api.ViewModels;
using Trip.Tests.PlatData;
using Trip.Data.Repositories;
using Trip.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trip.Data.Interfaces;
using Trip.Services.DTO;

namespace Trip.Tests.Repositories
{
    public class DossierRepositoryTest
    {
        private readonly DossierRepository _dossierRepository;
        private readonly Mock<DbContextClass> _dbContextMock;
        public DossierRepositoryTest()
        {

            _dbContextMock = new Mock<DbContextClass>();
            _dossierRepository = new DossierRepository(_dbContextMock.Object);
        }

        [Fact]
      public void Test_GetByEmail()
      {
          // Arrange
            var dossiers = DataHelper.GetDossiersList().AsQueryable();
            _dbContextMock.Setup(c => c.Set<Dossier>())
                                  .Returns(DataHelper.MockDbSet(dossiers));
            var userId = new Guid("11111111-1111-1111-1111-111111111111");

          // Act
          var user =  _dossierRepository.GetById(userId); 

          // Assert
          Assert.NotNull(user);
      } 

        [Fact]
        public void GetAllReservations_ReturnsExpectedResult()
        { 
            // Arrange
            var testData = DataHelper.GetDossiersList().AsQueryable();

            // Mock DbSet
            _dbContextMock.Setup(c => c.Set<Dossier>()).Returns(DataHelper.MockDbSet(testData));
            // Act
            List<Dossier> result = _dossierRepository.GetAllReservations();

            // Asset
            Assert.NotNull(result);
            Assert.Equal(testData.Count(), result.Count());

        }


        [Fact]
        public void GetById_ReturnsDossier_IfExists()
        {
            // Arrange
            var dossierId = Guid.NewGuid();

            var dossiers = DataHelper.GetDossiersListWithGeneratedGuid(dossierId).AsQueryable();

            _dbContextMock.Setup(c => c.Set<Dossier>())
                                .Returns(DataHelper.MockDbSet(dossiers));

            // Act
            var result =  _dossierRepository.GetById(dossiers.First().Id);

             // Assert
             Assert.NotNull(result);
             Assert.Equal(dossierId, result.Id); 
        }



        
    }
}
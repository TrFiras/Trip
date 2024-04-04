using Microsoft.EntityFrameworkCore;
using Moq;
using Trip.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trip.Api.ViewModels;

namespace Trip.Tests.PlatData
{
    public static class DataHelper
    {

        #region Dossiers
        public static List<Dossier> GetDossiersList()
        {
            var expectedDossiers = new List<Dossier>
            {
                new Dossier { Id = new Guid("11111111-1111-1111-1111-111111111111"), DossierNumber = "Dossier 1" },
                new Dossier { Id = Guid.NewGuid(), DossierNumber = "Dossier 2" }
            };
            return expectedDossiers;
        }

        public static List<Dossier> GetDossiersListWithGeneratedGuid(Guid dossierId)
        {
           var dossiers = new List<Dossier>
            {
                new Dossier { Id = dossierId, DossierNumber = "1", ClientId = Guid.NewGuid()},
                new Dossier { Id = Guid.NewGuid(), DossierNumber = "2", ClientId = Guid.NewGuid()},
                new Dossier { Id = Guid.NewGuid(), DossierNumber = "3", ClientId = Guid.NewGuid() }
            };
            return dossiers ;
        }
#endregion

#region HotelsList
public static List<Hotel> GenerateFakeHotels(Guid hotelId)
{
    var hotels = new List<Hotel>{
        new Hotel
        {
            Id = hotelId,
            Name = "Hotel 1",
            Ville ="Paris",
            Website = "Hotel1.com",
            Email= "Hotel1@gmail.com"
        },
       
    };

    return hotels;
}

        public static List<Hotel> GetTestHotels( Guid hotelId)
        {
            // Generate some test hotels
            return new List<Hotel>
            {
                new Hotel
                {
                    Id = hotelId,
                    Name = "Hotel 1",
                    Ville =" Paris",
                    Website = "Hotel1.com",
                    Email= "Hotel1@gmail.com"

                },
                new Hotel
                {
                    Id = Guid.NewGuid(),
                    Name = "Hotel 2",
                     Ville =" Madrid",
                    Website = "Hotel2.com",
                    Email= "Hotel2@gmail.com"

                }
            };
        }
        #endregion

        #region RoomsList
        public static List<Room> GenerateFakeRooms(Guid roomId)
{
    var rooms = new List<Room>{
        new Room
        {
             Id = roomId,
            Type = "Double",
            Price =100.0,
        },
       
    };

    return rooms;
}
#endregion

        #region FlightsList
        public static List<Flight> GenerateFlights()
            {
                // Generate some test flights
                var flights = new List<Flight>
                {
                    new Flight
                    {
                        Id = Guid.NewGuid(),
                        FlightDate = DateTime.UtcNow.Date.AddDays(1),
                        FlightNumber = "ABC123"
                    },
                    new Flight
                    {
                        Id = Guid.NewGuid(),
                        FlightDate = DateTime.UtcNow.Date.AddDays(2),
                        FlightNumber = "DEF456"
                    },
           
                };

                return flights;
            }
            #endregion

        #region AirportsList
public static List<Airport> GenerateAirports()
    {
        // Generate some test airports
        var airports = new List<Airport>
        {
            new Airport
            {
                Id = Guid.NewGuid(),
                Name = "John F. Kennedy International Airport",
                Code = "JFK",
                
            },
            new Airport
            {
                Id = Guid.NewGuid(),
                Name = "Heathrow Airport",
                Code = "LHR",
                
            },
            // Add more airports as needed...
        };

        return airports;
    }

    #endregion
        
        #region DataSet
    public static DbSet<T> MockDbSet<T>(IQueryable<T> data) where T : class
    {
        var mockSet = new Mock<DbSet<T>>();
        mockSet.As<IQueryable<T>>().Setup(m => m.Provider).Returns(data.Provider);
        mockSet.As<IQueryable<T>>().Setup(m => m.Expression).Returns(data.Expression);
        mockSet.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(data.ElementType);
        mockSet.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

        return mockSet.Object;
    }
        #endregion

        #region Client
        
            public static IQueryable<User> ArrangeUser(Guid id)
        {
            List<User> usersList = new List<User>() 
            {
                new User {
                Id = id,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                Password = "password",
                PhoneNumber = "123456789"
                }
            };
            return usersList.AsQueryable();
        }

        public static IQueryable<Client> ArrangeClient( Guid id)
        {
            List<Client> clientsList = new List<Client>()
            {
               new Client {  
                 ClientId = id,
                 PassportNumber = "Passport123",
                 IsActive = true,
                 AdresseId = Guid.NewGuid(),
                 UserId = Guid.NewGuid()
               }
             };
            return clientsList.AsQueryable();
        }
        #endregion

        #region User
        public static List<User> GetTestUsers()
        {
            return new List<User>
            {
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Unit Tester 1",
                    Email = "unit.tester1@abc.com",
                    Password = "password",
                    PhoneNumber = "1234567890"
                }
            };
        }

        public static List<Client> GetTestClients()
        {
            // Generate a new Guid for the user
            var userId = Guid.NewGuid();

            // Create a user instance with the generated user ID
            var user = new User
            {
                Id = userId,
                FirstName = "Unit Tester 1",
                Email = "unit.tester1@abc.com",
                Password = "password"
            };

            return new List<Client>
    {
        new Client
        {
            ClientId = Guid.NewGuid(),
            PassportNumber = "Passport123",
            IsActive = true,
            AdresseId = Guid.NewGuid(),
            UserId = userId,  // Assign the same user ID to the UserId of the client
            FellowTravellers = new List<FellowTraveller>(),
            Dossiers = new List<Dossier>(),
            address = new Address(),
            user = user  // Assign the user instance to the user property of the client
        }
    };
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Http;
using Trip.Data.Models;
using Trip.Data;
using Trip.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Trip.Data.Repositories;
using GraphQL;

namespace trip.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContextClass _dbContext;
        public IHotelRepository Hotels { get; }
        public IFlightRepository Flights { get; }
        public IAdressRepository Adresses { get; }
        public IAirportRepository Airports { get; }
        public IUserRepository Users { get; }
        public IClientRepository Clients { get; }
        public IDossierRepository Dossiers { get; }
        public IBookingRoomRepository BookingRooms { get; }
        public IRoomRepository Rooms { get; }

        public UnitOfWork(DbContextClass dbContext,
                            IHotelRepository hoteltRepository,
                            IFlightRepository flightRepository,
                            IAirportRepository airportRepository,
                            IAdressRepository adressRepository,
                            IUserRepository userRepository,
                            IClientRepository clientRepository,
                            IDossierRepository dossierRepository,
                            IBookingRoomRepository bookingRoomRepository,
                            IRoomRepository roomRepository
                      )

        {
            _dbContext = dbContext;
            Hotels = hoteltRepository;
            Flights = flightRepository;
            Airports = airportRepository;
            Users = userRepository;
            Clients = clientRepository;
            Dossiers = dossierRepository;
            BookingRooms = bookingRoomRepository;
            Adresses = adressRepository;
            Rooms = roomRepository;
        }






        private void AddTimestamps(IEnumerable<BaseModel> entities)
        {


            // DateTime.UtcNow is used to get the current UTC time
            var currentTime = DateTime.UtcNow;

            foreach (var entity in entities)
            {
                if (entity.CreatedAt == default(DateTime))
                {
                    // If the entity is being added for the first time, set CreatedAt and CreatedBy
                    entity.CreatedAt = currentTime;
                }

                // Always update LastModifiedAt and LastModifiedBy
                entity.LastModifiedAt = currentTime;
            }
        }


        public int Save()
        {
            AddTimestamps(_dbContext.ChangeTracker.Entries().Where(x => x.Entity is BaseModel && (x.State == EntityState.Added || x.State == EntityState.Modified)).Select(x => (BaseModel)x.Entity));

            return _dbContext.SaveChanges();
        }

        public Guid SaveReturnGuid<TEntity>() where TEntity : class {
            _dbContext.SaveChanges();
            var savedEntity = _dbContext.ChangeTracker.Entries<TEntity>()
                                  .FirstOrDefault(x => x.State != EntityState.Detached && x.State != EntityState.Deleted)?
                                  .Entity;
            var idProperty = typeof(TEntity).GetProperty("Id");
            return (Guid)(idProperty?.GetValue(savedEntity) ?? Guid.Empty);
        }
       

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
        }

    }
}

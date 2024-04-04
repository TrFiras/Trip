
using System;
using Trip.Data.Repositories;

namespace Trip.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IHotelRepository Hotels { get; }
        IFlightRepository Flights { get; }
        IAirportRepository Airports { get; }
        IAdressRepository Adresses { get; }
        IUserRepository Users { get; }
        IClientRepository Clients { get; }
        IDossierRepository Dossiers {get;}
        IBookingRoomRepository BookingRooms {get;}
        IRoomRepository Rooms {get;}

        int Save();
        Guid SaveReturnGuid<TEntity>() where TEntity : class;
    }
}

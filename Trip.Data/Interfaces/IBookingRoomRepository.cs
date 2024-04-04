using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Trip.Data.Models;

namespace Trip.Data.Interfaces
{
    public interface IBookingRoomRepository : IGenericRepository<BookingRoom>
    {
        bool CreateBookingRoom(BookingRoom bookingRoom, Guid dossierId, Guid roomId);
    }
}

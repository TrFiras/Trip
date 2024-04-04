using System;
using System.Threading.Tasks;
using Trip.Data.Models;
using Trip.Services.DTO;

namespace Trip.Services.Interfaces
{
    public interface IBookingRoomService
    {
        bool CreateBookingRoom(BookingRoomDTO bookingRoom, Guid dossierId, Guid roomId);
    }
}

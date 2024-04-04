using System;

namespace Trip.Data.Models
{
    public class RoomBookingRoom
    {
           public Guid RoomId { get; set; }
        public Guid BookingRoomId { get; set; }
        public Room room { get; set; }
        public BookingRoom bookingRoom { get; set; }
    }
}
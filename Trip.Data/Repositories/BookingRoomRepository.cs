using System;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Trip.Data.Interfaces;
using Trip.Data.Models;

namespace Trip.Data.Repositories
{
    public class BookingRoomRepository : GenericRepository<BookingRoom>, IBookingRoomRepository
    {
        public BookingRoomRepository(DbContextClass dbContext) : base(dbContext)
        {
        }
        public bool CreateBookingRoom(BookingRoom bookingRoom, Guid dossierId, Guid roomId)
        {
            return false;
        }
    }
}
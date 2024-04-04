using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trip.Data.Interfaces;
using Trip.Data.Models;

namespace Trip.Data.Repositories
{
    public class HotelRepository : GenericRepository<Hotel>, IHotelRepository
    {
        public HotelRepository(DbContextClass dbContext) : base(dbContext)
        {

        }

        public IEnumerable<Hotel> GetAllHotelsDetails()
        {
            return  _dbContext.Set<Hotel>()
                .Include(f => f.address)
                .Include(f => f.Rooms)
                .ThenInclude(x=> x.BookingRoom)
                .Include(f => f.Rooms)
                .ThenInclude(x=>x.Extra)
                .ToList();
        }

        

    public Hotel GetHotelById(Guid id)
      {
          // Implement your logic to retrieve the hotel by its Guid ID
          return  _dbContext.Set<Hotel>()
          .Include(x=>x.address)
          .Include(x=> x.Rooms)
          .ThenInclude(x=> x.Extra)
          .Include(x=> x.Rooms)
          .ThenInclude(x=> x.BookingRoom)
          .FirstOrDefault(h => h.Id == id);
      } 


    }
}

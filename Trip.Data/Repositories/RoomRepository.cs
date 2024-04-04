using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Trip.Data.Interfaces;
using Trip.Data.Models;

namespace Trip.Data.Repositories
{
    public class RoomRepository : GenericRepository<Room>, IRoomRepository
    {
        public RoomRepository(DbContextClass dbContext) : base(dbContext)
        {
        }

        public Room GetById(Guid id)
        {
            return  _dbContext.Rooms.FirstOrDefault(r => r.Id == id);
        }
    }
}

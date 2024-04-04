using System;
using System.Threading.Tasks;
using Trip.Data.Models;

namespace Trip.Data.Interfaces
{
    public interface IRoomRepository : IGenericRepository<Room>
    {
        Room GetById(Guid id);
    }
}

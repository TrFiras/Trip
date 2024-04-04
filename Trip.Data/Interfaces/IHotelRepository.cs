
using System.Collections.Generic;
using System.Threading.Tasks;
using Trip.Data.Models;
using System;
namespace Trip.Data.Interfaces
{
    public interface IHotelRepository : IGenericRepository<Hotel>
    {
                        IEnumerable<Hotel> GetAllHotelsDetails();
                        Hotel GetHotelById(Guid id);

    }
}

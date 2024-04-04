using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trip.Data.Models;

namespace Trip.Data.Interfaces
{
    public interface IAirportRepository : IGenericRepository<Airport>
    {
        IEnumerable<Airport> GetAllAirportsDetails();
    }
}
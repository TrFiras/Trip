using System.Collections.Generic;
using System.Threading.Tasks;
using Trip.Data.Models;

namespace Trip.Data.Interfaces
{
    public interface IFlightRepository : IGenericRepository<Flight>
    {
                IEnumerable<Flight> GetAllFlightsDetails();

    }
}

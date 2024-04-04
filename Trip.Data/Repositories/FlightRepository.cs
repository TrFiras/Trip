using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trip.Data.Interfaces;
using Trip.Data.Models;


namespace Trip.Data.Repositories
{
    public class FlightRepository : GenericRepository<Flight>, IFlightRepository
    {
        public FlightRepository(DbContextClass dbContext) : base(dbContext)
        {

        }

   public IEnumerable<Flight> GetAllFlightsDetails()
{
    return  _dbContext.Set<Flight>()
    
        .Include(f => f.flightAirports)
            .ThenInclude(fa => fa.airport)
           .ThenInclude(fa => fa.address)
        .Include(f => f.flightAirplanes)
            .ThenInclude(fa => fa.airplane)
        .Include(f => f.dossierFlights)
        .ToList();
}

    }
}

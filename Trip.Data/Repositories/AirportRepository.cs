using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trip.Data.Interfaces;
using Trip.Data.Models;
namespace Trip.Data.Repositories
{
    public class AirportRepository: GenericRepository<Airport>, IAirportRepository
    {
        public AirportRepository(DbContextClass dbContext) : base(dbContext)
        {

        }

            public IEnumerable<Airport> GetAllAirportsDetails()
            {
                return  _dbContext.Set<Airport>()
                    .Include(f => f.address)
                    .ToList();
            }

        
    }   
}
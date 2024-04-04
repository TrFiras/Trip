using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trip.Services.DTO
{
    public class AirportDTO
    {
         public Guid Id { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
    public Guid AddressId { get; set; }
    public AddressDTO Address { get; set; }
    public List<FlightAirportsDTO> FlightAirports { get; set; }
    }
}
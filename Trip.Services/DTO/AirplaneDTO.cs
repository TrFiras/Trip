using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trip.Data.Models;

namespace Trip.Services.DTO
{
    public class AirplaneDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string Company { get; set; }

        public ICollection<FlightAirplanes>? flightAirplanes { get; set; }
    }
}
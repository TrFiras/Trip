using System;

namespace Trip.Data.Models
{
    public class FlightAirplanes
    {
        public Guid Id { get; set; }
         public Guid FlightId { get; set; }
        public Guid AirplaneId { get; set; }
        public Airplane airplane { get; set; }
        public Flight flight { get; set; }
    }
}
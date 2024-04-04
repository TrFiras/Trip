using System;

namespace Trip.Data.Models
{
    public class FlightAirports:BaseModel
    {
        public Guid FlightId { get; set; }
        public Guid AirportId { get; set; }
        public Airport airport { get; set; }
        public Flight flight { get; set; }
        public Guid Id { get; set; }
}
}
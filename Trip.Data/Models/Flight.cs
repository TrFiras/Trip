using System;
using System.Collections.Generic;

namespace Trip.Data.Models
{
  public class Flight:BaseModel
{
    public Guid Id { get; set; }
    public DateTime FlightDate { get; set; }
    public string FlightNumber { get; set; }
    
    public ICollection<FlightAirports> flightAirports { get; set; }
    public ICollection<FlightAirplanes> flightAirplanes { get; set; }
    public ICollection<DossierFlight> dossierFlights { get; set; }
}
}
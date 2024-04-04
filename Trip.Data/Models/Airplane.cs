using System;
using System.Collections.Generic;

namespace Trip.Data.Models
{
    public class Airplane:BaseModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Capacity { get; set; }
    public string Company { get; set; }

     public ICollection<FlightAirplanes>? flightAirplanes { get; set; }
}
}
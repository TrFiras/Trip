using System;
using System.Collections.Generic;
namespace Trip.Api.ViewModels
{
    public class FlightAirplanesViewModel
{
    public Guid FlightId { get; set; }
    public Guid AirplaneId { get; set; }
    public AirplaneViewModel Airplane { get; set; }
    public FlightViewModel Flight { get; set; }
}
}
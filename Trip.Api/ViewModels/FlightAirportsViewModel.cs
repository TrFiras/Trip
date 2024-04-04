using System;
using System.Collections.Generic;
using Trip.Api.ViewModels;
namespace Trip.Api.ViewModels

{
  public class FlightAirportsViewModel : BaseModelViewModel
{
    public Guid FlightId { get; set; }
    public Guid AirportId { get; set; }
    public AirportViewModel Airport { get; set; }
    public FlightViewModel Flight { get; set; }
}
}
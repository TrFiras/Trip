using System;
using System.Collections.Generic;
namespace Trip.Api.ViewModels
{
    public class AirportViewModel
    {
          public Guid Id { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
    public Guid AddressId { get; set; }
    public AddressViewModel Address { get; set; }
    public List<FlightAirportsViewModel> FlightAirports { get; set; }
    }
}
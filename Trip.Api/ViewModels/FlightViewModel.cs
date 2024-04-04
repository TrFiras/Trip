using System;
using System.Collections.Generic;
namespace Trip.Api.ViewModels
{
    public class FlightViewModel : BaseModelViewModel
{
    public DateTime FlightDate { get; set; }
    public string FlightNumber { get; set; }
    public ICollection<FlightAirportsViewModel> FlightAirports { get; set; }
    public ICollection<FlightAirplanesViewModel> FlightAirplanes { get; set; }
    public ICollection<DossierFlightViewModel> DossierFlights { get; set; }
}
}
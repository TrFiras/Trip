using System;
using System.Collections.Generic;
namespace Trip.Api.ViewModels
{
    public class AirplaneViewModel : BaseModelViewModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Capacity { get; set; }
    public string Company { get; set; }
    public ICollection<FlightAirplanesViewModel> FlightAirplanes { get; set; }
}
}

using System;
using System.Collections.Generic;

namespace Trip.API.ViewModels;

public class GetFlightResponse
{
    public Guid Id { get; set; }
    public DateTime FlightDate { get; set; }
    public string FlightNumber { get; set; }
    public List<FlightAirportResponse> FlightAirports { get; set; }
    public List<FlightAirplaneResponse> FlightAirplanes { get; set; }
}

public class FlightAirportResponse
{
    public Guid AirportId { get; set; }
    public string AirportName { get; set; }
    public string AirportCode { get; set; }
}

public class FlightAirplaneResponse
{
    public Guid AirplaneId { get; set; }
    public string AirplaneName { get; set; }
    public int Capacity { get; set; }
    public string Company { get; set; }
}

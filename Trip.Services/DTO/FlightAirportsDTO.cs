using System;
namespace Trip.Services.DTO
{
    public class FlightAirportsDTO : BaseModelDTO
{
    public Guid FlightId { get; set; }
    public Guid AirportId { get; set; }
    public AirportDTO Airport { get; set; }
    public FlightDTO Flight { get; set; }
}
}
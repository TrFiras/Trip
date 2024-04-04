/* using GraphQL.Types;
using Trip.Services.Interfaces;

public class AirportResolver : ObjectGraphType
{
    public AirportResolver(IAirportService airportService)
    {
        Field<ListGraphType<AirportType>>(
            "airports",
            resolve: context => airportService.GetAllAirports()
        );
    }
} */
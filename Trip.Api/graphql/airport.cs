using HotChocolate.Types;
using Trip.Data.Models;
namespace Trip.Api.graphql
{
public class AirportType : ObjectType<Airport>
{
    protected override void Configure(IObjectTypeDescriptor<Airport> descriptor)
    {
        descriptor.Field(h => h.Id).Type<IdType>();
        descriptor.Field(h => h.Name).Type<StringType>();
    }
}
}
using HotChocolate.Types;
using Trip.Data.Models;
namespace Trip.Api.graphql
{
    public class FlightType : ObjectType<Flight>
    {
        protected override void Configure(IObjectTypeDescriptor<Flight> descriptor)
        {
            descriptor.Field(h => h.Id).Type<IdType>();
            descriptor.Field(h => h.FlightDate).Type<DateType>();
            descriptor.Field(h => h.FlightNumber).Type<StringType>();
        }
    }
}
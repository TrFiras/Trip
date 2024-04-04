using HotChocolate.Types;
using Trip.Data.Models;
namespace Trip.Api.graphql
{
public class HotelType : ObjectType<Hotel>
{
    protected override void Configure(IObjectTypeDescriptor<Hotel> descriptor)
    {
        descriptor.Field(h => h.Id).Type<IdType>();
        descriptor.Field(h => h.Name).Type<StringType>();
    }
}
}
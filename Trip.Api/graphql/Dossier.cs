using HotChocolate.Types;
using Trip.Data.Models;

namespace Trip.Api.graphql
{
    public class DossierType : ObjectType<Dossier>
    {
        protected override void Configure(IObjectTypeDescriptor<Dossier> descriptor)
        {
            descriptor.Field(d => d.Id).Type<IdType>();
            descriptor.Field(d => d.DossierNumber).Type<StringType>();
            descriptor.Field(d => d.ClientId).Type<IdType>();
            descriptor.Field(d => d.FlightId).Type<IdType>();
            descriptor.Field(d => d.BookingRoomId).Type<IdType>();
            descriptor.Field(d => d.Client.UserId).Type<IdType>();

        }
    }
}

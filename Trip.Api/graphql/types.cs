using HotChocolate.Types;
using System;
using Trip.Api.graphql;
using Trip.Data.Interfaces;
using Trip.Data.Models;
public class GraphQLQueryType : ObjectType
{
    protected override void Configure(IObjectTypeDescriptor descriptor)
    {
        descriptor.Name("Query");

          descriptor.Field("hotels")
            .Type<ListType<HotelType>>()
            .Resolver(context =>
            {
                var unitOfWork = context.Service<IUnitOfWork>(); // Get the UnitOfWork instance from the context
                var hotels = unitOfWork.Hotels.GetAllHotelsDetails(); // Get all hotels from the repository
                return hotels; // Return the list of hotels
            });

        descriptor.Field("flights")
            .Type<ListType<FlightType>>()
            .Resolver(context =>
            {
                var unitOfWork = context.Service<IUnitOfWork>(); // Get the UnitOfWork instance from the context
                var flights = unitOfWork.Flights.GetAllFlightsDetails(); // Get all flights from the repository
                return flights; // Return the list of flights
            });

        descriptor.Field("dossiers")
            .Type<ListType<DossierType>>()
            .Resolver(context =>
            {
                var unitOfWork = context.Service<IUnitOfWork>(); // Get the UnitOfWork instance from the context
                var dossiers = unitOfWork.Dossiers.GetAllReservations(); // Get all dossiers from the repository
                return dossiers; // Return the list of dossiers
            });
            
            descriptor.Field("dossiersByClient")
            .Type<ListType<DossierType>>()
            .Argument("firstName", arg => arg.Type<StringType>())
            .Argument("lastName", arg => arg.Type<StringType>())
            .Resolver(context =>
            {
                var unitOfWork = context.Service<IUnitOfWork>();
                var firstName = context.Argument<string>("firstName");
                var lastName = context.Argument<string>("lastName");
                var dossiers = unitOfWork.Dossiers.GetDossiersByClientName(firstName, lastName);
                return dossiers;
            });

 descriptor.Field("hotelById")
            .Type<HotelType>()
            .Argument("id", arg => arg.Type<IdType>())
            .Resolver(context =>
            {
                var unitOfWork = context.Service<IUnitOfWork>();
                var hotelId = context.Argument<Guid>("id");
                var hotel = unitOfWork.Hotels.GetHotelById(hotelId);
                return hotel;
            });
        

        // get List of Airports
        descriptor.Field("airports")
       .Type<ListType<AirportType>>()
       .Resolver(context =>
       {
           var unitOfWork = context.Service<IUnitOfWork>(); // Get the UnitOfWork instance from the context
           var airports = unitOfWork.Airports.GetAllAirportsDetails (); // Get all airports from the repository
           return airports; // Return the list of airports
       });
    }
}

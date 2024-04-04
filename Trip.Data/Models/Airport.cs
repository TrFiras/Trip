using System;
using System.Collections.Generic;
using GraphQL.Types;
namespace Trip.Data.Models
{
    public class Airport : BaseModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Guid AdressId { get; set; }
        public Address address { get; set; }
        public List<FlightAirports>? flightAirports { get; set; }
 }
 
}
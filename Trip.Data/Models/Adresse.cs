using System;

namespace Trip.Data.Models
{
    public class Address : BaseModel
    {
        public Guid Id { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }


    }
}
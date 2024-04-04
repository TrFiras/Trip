using System;
using System.Collections.Generic;
namespace Trip.Api.ViewModels
{
    public class AddressViewModel
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
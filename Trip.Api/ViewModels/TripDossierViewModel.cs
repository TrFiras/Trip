using System;
using System.Collections.Generic;
using Trip.Data.Models;

namespace Trip.API.ViewModels
{
    public class TripDossierViewModel
    {
        public Guid Id { get; set; }
        public string DossierNumber { get; set; }
        public Guid ClientId { get; set; }
        public Guid? FlightId { get; set; }
        public Guid? BookingRoomId { get; set; }
        public virtual ICollection<DossierFlight> dossierFlights { get; set; }


        public virtual Client Client { get; set; }
        public virtual Flight Flight { get; set; }
        public virtual BookingRoom BookingRoom { get; set; }
    }
}
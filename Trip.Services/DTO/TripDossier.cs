using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trip.Services.DTO
{
    public class TripDossier
    {
        public Guid DossierId { get; set; }
        public string DossierNumber { get; set; }
        public string LastName { get; set; }
        public Guid ClientId { get; set; }
        public Guid FlightId { get; set; }
        public Guid BookingRoomId { get; set; }
    }
}
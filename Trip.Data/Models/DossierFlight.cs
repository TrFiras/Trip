using System;

namespace Trip.Data.Models
{
    public class DossierFlight
    {
        public Guid DossierId {get; set; }
        public Guid FlightId {get; set; }
         public Dossier dossier {get; set; }
          public Flight flight {get; set; }
    }
}
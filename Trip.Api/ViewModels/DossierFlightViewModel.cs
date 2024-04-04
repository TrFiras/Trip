using System;
using System.Collections.Generic;
using Trip.API.ViewModels;

namespace Trip.Api.ViewModels
{
    public class DossierFlightViewModel
    {
            public Guid DossierId { get; set; }
    public Guid FlightId { get; set; }
    public TripDossierViewModel Dossier { get; set; }
    public FlightViewModel Flight { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Trip.Services.DTO
{
    public class DossierFlightDTO
{
    public Guid DossierId { get; set; }
    public Guid FlightId { get; set; }
    public DossierDTO Dossier { get; set; }
    public FlightDTO Flight { get; set; }
}
}
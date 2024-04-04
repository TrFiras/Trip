using AutoMapper;
using TripDossierDto = Trip.Services.DTO.TripDossier;
using System.Linq;
using Trip.Data.Models;
using Trip.Services.DTO;

namespace Trip.Services.MappingProfiles
{
    public class AirportProfile : Profile
    {
        public AirportProfile()
        {
            CreateMap<Airport, AirportDTO>();
            CreateMap<AirportDTO, Airport>();
        }
    }
}
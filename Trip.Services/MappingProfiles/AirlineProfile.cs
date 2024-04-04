using AutoMapper;
using TripDossierDto = Trip.Services.DTO.TripDossier;
using System.Linq;
using Trip.Data.Models;
using Trip.Services.DTO;

namespace Trip.Services.MappingProfiles
{
    public class AirlineProfile : Profile
    {
        public AirlineProfile()
        {
            CreateMap<Airplane, AirplaneDTO>();
            CreateMap<AirplaneDTO, Airplane>();
        }
    }
}
using AutoMapper;
using Trip.Api.ViewModels;
using Trip.Services.DTO;
namespace Trip.Api.MappingProfiles
{
    public class FlightProfile : Profile
    {
        public FlightProfile()
        {
            CreateMap<FlightViewModel, FlightDTO>();
            CreateMap<FlightDTO, FlightViewModel>();
        }
    }
}
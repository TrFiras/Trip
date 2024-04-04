using AutoMapper;
using Trip.Api.ViewModels;
using Trip.Services.DTO;
namespace Trip.Api.MappingProfiles
{
    public class AirportProfile : Profile
    {
         public AirportProfile()
        {
            CreateMap<AirportViewModel, AirportDTO>();
            CreateMap<AirportDTO, AirportViewModel>();
        }
    }
}
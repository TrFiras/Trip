using AutoMapper;
using Trip.Api.ViewModels;
using Trip.Services.DTO;
namespace Trip.Api.MappingProfiles
{
    public class HotelProfile : Profile
    {
         public HotelProfile()
        {
            CreateMap<HotelViewModel, HotelDTO>();
            CreateMap<HotelDTO, HotelViewModel>();
        }
    }
}
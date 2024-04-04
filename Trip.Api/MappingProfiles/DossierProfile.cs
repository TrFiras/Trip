using AutoMapper;

using Trip.Services.DTO;
using Trip.Api.ViewModels;
using Trip.API.ViewModels;
namespace Trip.API.MappingProfiles
{
    public class DossierProfile : Profile
    {
        public DossierProfile()
        {
            CreateMap<TripDossierViewModel, DossierDTO>();
            CreateMap<DossierDTO, TripDossierViewModel>();
            CreateMap<BookedRoomInfoDTO, BookedRoomInfoViewModel>();
            CreateMap<BookedRoomInfoViewModel, BookedRoomInfoDTO>();
        }
    }
}
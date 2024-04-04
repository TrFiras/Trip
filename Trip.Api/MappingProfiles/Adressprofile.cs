using AutoMapper;
using Trip.Api.ViewModels;
using Trip.Services.DTO;
namespace Trip.Api.MappingProfiles
{
    public class Adressprofile : Profile
    {
        public Adressprofile()
        {
            CreateMap<AddressViewModel, AddressDTO>();
            CreateMap<AddressDTO, AddressViewModel>();
        }
        
    }
}
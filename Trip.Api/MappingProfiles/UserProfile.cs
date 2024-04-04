using AutoMapper;
using Trip.Api.ViewModels;
using Trip.Services.DTO;
namespace Trip.Api.MappingProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserViewModel, UserDTO>();
            CreateMap<UserDTO, UserViewModel>();
        }
        
    }
}
using AutoMapper;
using TripDossierDto = Trip.Services.DTO.TripDossier;
using System.Linq;
using Trip.Data.Models;
using Trip.Services.DTO;

namespace Trip.Services.MappingProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
        }
    }
}
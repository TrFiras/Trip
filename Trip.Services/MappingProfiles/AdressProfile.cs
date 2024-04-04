using AutoMapper;
using System.Linq;
using Trip.Data.Models;
using Trip.Services.DTO;

namespace Trip.Services.MappingProfiles
{
    public class AdressProfile : Profile
    {
        public AdressProfile()
        {
            CreateMap<Address, AddressDTO>();
            CreateMap<AddressDTO, Address>();
        }
    }
}
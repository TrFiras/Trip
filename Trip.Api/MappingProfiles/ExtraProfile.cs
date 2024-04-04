using AutoMapper;
using Trip.Api.ViewModels;
using Trip.Services.DTO;
namespace Trip.Api.MappingProfiles
{
    public class ExtraProfile : Profile
    {public ExtraProfile()
        {
           CreateMap<ExtraViewModel, ExtraDTO>();
            CreateMap<ExtraDTO, ExtraViewModel>();
        }
         
    }
}
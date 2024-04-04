using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Trip.Api.ViewModels;
using Trip.Services.Interfaces;

namespace Trip.API.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class AirportController : ControllerBase
    {
        public readonly IAirportService _airportService;
        private readonly IMapper _mapper;

        public AirportController(IAirportService airportService, IMapper mapper)
        {
            _airportService = airportService;
            _mapper = mapper;
        }



        [HttpGet]
        public IActionResult GetAirportList()
        {
            var AirportList =  _airportService.GetAllAirports();
            if (AirportList == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<IEnumerable<AirportViewModel>>(AirportList));
        }
    }
}
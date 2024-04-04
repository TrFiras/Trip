using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using System.Threading.Tasks;
using System.Collections.Generic;
using Trip.API.ViewModels;
using Trip.Services.Interfaces;
using Trip.Api.ViewModels;
using Trip.Services.DTO;
namespace Trip.API.Controllers
{
    [Route("api/[controller]")]
[ApiController]
public class FlightsController : ControllerBase
{
    public readonly IFlightService _flightService;
    private readonly IMapper _mapper; // Add IMapper field

    public FlightsController(IFlightService flightService, IMapper mapper)
    {
        _flightService = flightService;
        _mapper = mapper;

    }

    /// <summary>
    /// Get the list of product
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public IActionResult GetFlightsList()
    {
        var flightsList =  _flightService.GetAllFlights();
        if (flightsList == null)
        {
            return NotFound();
        }

        return Ok(_mapper.Map<IEnumerable<FlightDTO>>(flightsList));
    }



}
}
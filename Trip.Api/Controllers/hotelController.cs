using Microsoft.AspNetCore.Mvc;

using AutoMapper;
using System.Threading.Tasks;
using System.Collections.Generic;
using Trip.API.ViewModels;
using Trip.Services.Interfaces;
using Trip.Api.ViewModels;
using System;
using System.Linq;

namespace Trip.API.Controllers
{
    [Route("api/[controller]")]
[ApiController]
public class HotelsController : ControllerBase
{
    public readonly IHotelService _hotelService;
    private readonly IMapper _mapper; // Add IMapper field

    public HotelsController(IHotelService hotelService, IMapper mapper)
    {
        _hotelService = hotelService;
        _mapper = mapper;

    }

    /// <summary>
    /// Get the list of product
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public IActionResult GetHotelsList()
    {
        var HotelsList =  _hotelService.GetAllHotels();
        if (HotelsList == null)
        {
            return NotFound();
        }
            Console.WriteLine(HotelsList.Count());
        return Ok(_mapper.Map<IEnumerable<HotelViewModel>>(HotelsList));
    }



}
}
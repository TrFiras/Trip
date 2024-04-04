using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;
using Trip.Services.Interfaces;
using Trip.API.Helpers;
using Trip.Api.ViewModels;
using Trip.Services.DTO;
using Trip.Data.Models;
using Trip.API.ViewModels;

namespace Trip.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DossierController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        private readonly IDossierService _dossierService;
        private readonly IConfiguration _config;


        public DossierController(ILogger<DossierController> logger,
            IMapper mapper,
            IDossierService dossierService,
            IConfiguration config)
        {
            _logger = logger;
            _mapper = mapper;
            _dossierService = dossierService;
            _config = config;

        }

        [HttpPost("CreateDossier")]
    public ActionResult<TripDossierViewModel> CreateDossier([FromBody] TripDossierViewModel dossier)
    {
        var createdDossier = _dossierService.AddDossier(_mapper.Map<DossierDTO>(dossier));
        return CreatedAtAction(nameof(GetAll), dossier);
    }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            _logger.LogInformation("Get  trip dossiers list");
            try
            {
                var listTripDossiers =  _dossierService.GetAll();
            return Ok(_mapper.Map<IEnumerable<TripDossierViewModel>>(listTripDossiers));

            }
            catch (Exception exception)
            {
                var message = ExceptionHelper.GetExceptionMassage(exception);
                _logger.LogError(message);
                return StatusCode(StatusCodes.Status500InternalServerError, message);
            }
        }
        [HttpGet("GetDossiersByClientName")]
        public IActionResult GetDossiersByClientName(string firstName, string lastName)
        {
            _logger.LogInformation($"Get dossiers for client: {firstName} {lastName}");
            try
            {
                var dossiers =  _dossierService.GetDossiersByClientName(firstName, lastName);
                return Ok(_mapper.Map<IEnumerable<TripDossierViewModel>>(dossiers));
            }
            catch (Exception exception)
            {
                var message = ExceptionHelper.GetExceptionMassage(exception);
                _logger.LogError(message);
                return StatusCode(StatusCodes.Status500InternalServerError, message);
            }
        }

        [HttpPost("/BookRomm")]
        public IActionResult BookRoom(DateTime dateDebut, DateTime dateFin, Guid UserID, List<RoomDTO> myBookedRooms)
        {
            _logger.LogInformation("Book rooms in a hotel");
             try
            {
                var BookedRoomsInfo = _dossierService.BookRoom(dateDebut, dateFin, UserID, myBookedRooms);
                return Ok(_mapper.Map<BookedRoomInfoViewModel>(BookedRoomsInfo));

            }
            catch (Exception exception)
            {
                var message = ExceptionHelper.GetExceptionMassage(exception);
                _logger.LogError(message);
                return StatusCode(StatusCodes.Status500InternalServerError, message);
            } 
            
        }

    }
    }
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trip.Services.Interfaces;
using Trip.Data.Models;
using Trip.Data;
using Microsoft.AspNetCore.Cors;
using AutoMapper;
using System.Collections.Generic;
using Trip.Api.ViewModels;
using Trip.API.ViewModels;


namespace Trip.API.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        public readonly IClientService _clientService;
        private readonly IMapper _mapper;

        public ClientController(IClientService clientService,  IMapper mapper)
        {
            _clientService = clientService;
            _mapper = mapper;
        }

    
        [HttpGet]
        public IActionResult GetClientList()
        {
            var ClientsList =  _clientService.GetAllClients();
            if(ClientsList == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<IEnumerable<ClientViewModel>>(ClientsList));
        }

       
    }
}
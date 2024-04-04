using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trip.Services.Interfaces;
using Trip.Api.ViewModels;
using AutoMapper;
using Trip.Services.DTO;
using Microsoft.AspNetCore.Cors;

namespace Trip.API.Controllers
{
   
     [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly IUserService _userService;
        private readonly IMapper _mapper;
        public UserController(IUserService userService,
        IMapper mapper)
        {
            _userService = userService;
             _mapper = mapper;
        }

        
        [HttpGet]
        public IActionResult GetUserList()
        {
            var UsersList =  _userService.GetAllUsers();
            if(UsersList == null)
            {
                return NotFound();
            }
            return Ok(UsersList);
        }
        [HttpGet("{email}")]
        public IActionResult GetUserByEmail(string email)
        {
            try
            {
                var user =  _userService.GetUserByEmail(email);
                if (user == null)
                {
                    return NotFound($"User with email '{email}' not found.");
                }

                return Ok(user);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it appropriately
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost]
        [EnableCors("AllowOrigin")]
        public IActionResult CreateUser(UserViewModelData user)
        {
            UserViewModel usrData = new UserViewModel
            {
                Email = user.Email,
                Password = user.Password,
                FirstName = user.FirstName,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber,
                PassportNumber = user.PassportNumber,
                Adresse = new AddressViewModel { City = user.Adresse }

            };
            UserDTO mappedUser = _mapper.Map<UserDTO>(usrData);
            var isUserCreated =  _userService.Register(mappedUser);

            if (isUserCreated)
            {
                return Ok(isUserCreated);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [Route("login")]
        public IActionResult Login(UserLoginViewModel userData)
        {
            try
            {
                var user =  _userService.GetUserByEmailAndPassword(userData.Email,userData.Password);
                if (user == null)
                {
                    return NotFound("Invalid email or password.");
                }

                return Ok(user);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it appropriately
                return StatusCode(500, "Internal server error");
            }
        }
  }
}